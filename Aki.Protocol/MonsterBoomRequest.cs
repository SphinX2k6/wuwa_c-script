using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F4 RID: 2548
	[NetMessage(EMessageId.MonsterBoomRequest)]
	public sealed class MonsterBoomRequest : IMessage<MonsterBoomRequest>, IMessage, IEquatable<MonsterBoomRequest>, IDeepCloneable<MonsterBoomRequest>, IBufferMessage
	{
		// Token: 0x0600DF22 RID: 57122 RVA: 0x0020B7A5 File Offset: 0x002099A5
		[NullableContext(1)]
		public static MonsterBoomRequest Create()
		{
			return new MonsterBoomRequest();
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600DF23 RID: 57123 RVA: 0x0020B7AC File Offset: 0x002099AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x0020B7AF File Offset: 0x002099AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomRequest.Descriptor;
			}
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x0020B7B6 File Offset: 0x002099B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest()
		{
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x0020B7BE File Offset: 0x002099BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest(MonsterBoomRequest other) : this()
		{
			this.delay_ = other.delay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF27 RID: 57127 RVA: 0x0020B7E3 File Offset: 0x002099E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest Clone()
		{
			return new MonsterBoomRequest(this);
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x0020B7EB File Offset: 0x002099EB
		// (set) Token: 0x0600DF29 RID: 57129 RVA: 0x0020B7F3 File Offset: 0x002099F3
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

		// Token: 0x0600DF2A RID: 57130 RVA: 0x0020B7FC File Offset: 0x002099FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomRequest);
		}

		// Token: 0x0600DF2B RID: 57131 RVA: 0x0020B80A File Offset: 0x00209A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomRequest other)
		{
			return other != null && (other == this || (this.Delay == other.Delay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF2C RID: 57132 RVA: 0x0020B838 File Offset: 0x00209A38
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

		// Token: 0x0600DF2D RID: 57133 RVA: 0x0020B877 File Offset: 0x00209A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF2E RID: 57134 RVA: 0x0020B884 File Offset: 0x00209A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF2F RID: 57135 RVA: 0x0020B88D File Offset: 0x00209A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Delay != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF30 RID: 57136 RVA: 0x0020B8C0 File Offset: 0x00209AC0
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

		// Token: 0x0600DF31 RID: 57137 RVA: 0x0020B8FE File Offset: 0x00209AFE
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

		// Token: 0x0600DF32 RID: 57138 RVA: 0x0020B92F File Offset: 0x00209B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF33 RID: 57139 RVA: 0x0020B938 File Offset: 0x00209B38
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Delay = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C08 RID: 23560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C09 RID: 23561
		public const int DelayFieldNumber = 1;

		// Token: 0x04005C0A RID: 23562
		private int delay_;
	}
}
