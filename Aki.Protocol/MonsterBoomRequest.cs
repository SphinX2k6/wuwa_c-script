using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E3 RID: 2531
	[NetMessage(EMessageId.MonsterBoomRequest)]
	public sealed class MonsterBoomRequest : IMessage<MonsterBoomRequest>, IMessage, IEquatable<MonsterBoomRequest>, IDeepCloneable<MonsterBoomRequest>, IBufferMessage
	{
		// Token: 0x0600DE08 RID: 56840 RVA: 0x002095B9 File Offset: 0x002077B9
		[NullableContext(1)]
		public static MonsterBoomRequest Create()
		{
			return new MonsterBoomRequest();
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x002095C0 File Offset: 0x002077C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0600DE0A RID: 56842 RVA: 0x002095C3 File Offset: 0x002077C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomRequest.Descriptor;
			}
		}

		// Token: 0x0600DE0B RID: 56843 RVA: 0x002095CA File Offset: 0x002077CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest()
		{
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x002095D2 File Offset: 0x002077D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest(MonsterBoomRequest other) : this()
		{
			this.delay_ = other.delay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x002095F7 File Offset: 0x002077F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest Clone()
		{
			return new MonsterBoomRequest(this);
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0600DE0E RID: 56846 RVA: 0x002095FF File Offset: 0x002077FF
		// (set) Token: 0x0600DE0F RID: 56847 RVA: 0x00209607 File Offset: 0x00207807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delay
		{
			get
			{
				return this.delay_;
			}
			set
			{
				this.delay_ = value;
			}
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x00209610 File Offset: 0x00207810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomRequest);
		}

		// Token: 0x0600DE11 RID: 56849 RVA: 0x0020961E File Offset: 0x0020781E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomRequest other)
		{
			return other != null && (other == this || (this.Delay == other.Delay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE12 RID: 56850 RVA: 0x0020964C File Offset: 0x0020784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Delay != 0)
			{
				num ^= this.Delay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x0020968B File Offset: 0x0020788B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x00209698 File Offset: 0x00207898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x002096A1 File Offset: 0x002078A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Delay != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x002096D4 File Offset: 0x002078D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Delay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x00209712 File Offset: 0x00207912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterBoomRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Delay != 0)
			{
				this.Delay = other.Delay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x00209743 File Offset: 0x00207943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x0020974C File Offset: 0x0020794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Delay = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C11 RID: 23569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C12 RID: 23570
		public const int DelayFieldNumber = 4;

		// Token: 0x04005C13 RID: 23571
		private int delay_;
	}
}
