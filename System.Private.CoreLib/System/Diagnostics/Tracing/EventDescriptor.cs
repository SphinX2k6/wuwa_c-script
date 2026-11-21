using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D4 RID: 2260
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	internal readonly struct EventDescriptor : IEquatable<EventDescriptor>
	{
		// Token: 0x06008B70 RID: 35696 RVA: 0x00150D0F File Offset: 0x0014EF0F
		public EventDescriptor(int traceloggingId, byte level, byte opcode, long keywords)
		{
			this.m_id = 0;
			this.m_version = 0;
			this.m_channel = 0;
			this.m_traceloggingId = traceloggingId;
			this.m_level = level;
			this.m_opcode = opcode;
			this.m_task = 0;
			this.m_keywords = keywords;
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x00150D4C File Offset: 0x0014EF4C
		public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(id, "id");
			if (id > 65535)
			{
				throw new ArgumentOutOfRangeException("id", SR.Format(SR.ArgumentOutOfRange_NeedValidId, 1, ushort.MaxValue));
			}
			this.m_traceloggingId = 0;
			this.m_id = (ushort)id;
			this.m_version = version;
			this.m_channel = channel;
			this.m_level = level;
			this.m_opcode = opcode;
			this.m_keywords = keywords;
			ArgumentOutOfRangeException.ThrowIfNegative<int>(task, "task");
			if (task > 65535)
			{
				throw new ArgumentOutOfRangeException("task", SR.Format(SR.ArgumentOutOfRange_NeedValidId, 1, ushort.MaxValue));
			}
			this.m_task = (ushort)task;
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x00150E09 File Offset: 0x0014F009
		public int EventId
		{
			get
			{
				return (int)this.m_id;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06008B73 RID: 35699 RVA: 0x00150E11 File Offset: 0x0014F011
		public byte Version
		{
			get
			{
				return this.m_version;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x00150E19 File Offset: 0x0014F019
		public byte Channel
		{
			get
			{
				return this.m_channel;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06008B75 RID: 35701 RVA: 0x00150E21 File Offset: 0x0014F021
		public byte Level
		{
			get
			{
				return this.m_level;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06008B76 RID: 35702 RVA: 0x00150E29 File Offset: 0x0014F029
		public byte Opcode
		{
			get
			{
				return this.m_opcode;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00150E31 File Offset: 0x0014F031
		public int Task
		{
			get
			{
				return (int)this.m_task;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06008B78 RID: 35704 RVA: 0x00150E39 File Offset: 0x0014F039
		public long Keywords
		{
			get
			{
				return this.m_keywords;
			}
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00150E44 File Offset: 0x0014F044
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is EventDescriptor)
			{
				EventDescriptor other = (EventDescriptor)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00150E69 File Offset: 0x0014F069
		public override int GetHashCode()
		{
			return (int)(this.m_id ^ (ushort)this.m_version ^ (ushort)this.m_channel ^ (ushort)this.m_level ^ (ushort)this.m_opcode ^ this.m_task) ^ (int)this.m_keywords;
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00150E9C File Offset: 0x0014F09C
		public bool Equals(EventDescriptor other)
		{
			return this.m_id == other.m_id && this.m_version == other.m_version && this.m_channel == other.m_channel && this.m_level == other.m_level && this.m_opcode == other.m_opcode && this.m_task == other.m_task && this.m_keywords == other.m_keywords;
		}

		// Token: 0x04001F55 RID: 8021
		[FieldOffset(0)]
		private readonly int m_traceloggingId;

		// Token: 0x04001F56 RID: 8022
		[FieldOffset(0)]
		private readonly ushort m_id;

		// Token: 0x04001F57 RID: 8023
		[FieldOffset(2)]
		private readonly byte m_version;

		// Token: 0x04001F58 RID: 8024
		[FieldOffset(3)]
		private readonly byte m_channel;

		// Token: 0x04001F59 RID: 8025
		[FieldOffset(4)]
		private readonly byte m_level;

		// Token: 0x04001F5A RID: 8026
		[FieldOffset(5)]
		private readonly byte m_opcode;

		// Token: 0x04001F5B RID: 8027
		[FieldOffset(6)]
		private readonly ushort m_task;

		// Token: 0x04001F5C RID: 8028
		[FieldOffset(8)]
		private readonly long m_keywords;
	}
}
