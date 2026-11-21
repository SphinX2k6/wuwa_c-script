using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000263 RID: 611
	[NetMessage(EMessageId.ChangeStateConfirmPush)]
	public sealed class ChangeStateConfirmPush : IMessage<ChangeStateConfirmPush>, IMessage, IEquatable<ChangeStateConfirmPush>, IDeepCloneable<ChangeStateConfirmPush>, IBufferMessage
	{
		// Token: 0x060040D8 RID: 16600 RVA: 0x0009F6F0 File Offset: 0x0009D8F0
		[NullableContext(1)]
		public static ChangeStateConfirmPush Create()
		{
			return new ChangeStateConfirmPush();
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x0009F6F7 File Offset: 0x0009D8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x0009F6FA File Offset: 0x0009D8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmPush.Descriptor;
			}
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x0009F701 File Offset: 0x0009D901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush()
		{
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x0009F709 File Offset: 0x0009D909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush(ChangeStateConfirmPush other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x0009F73A File Offset: 0x0009D93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush Clone()
		{
			return new ChangeStateConfirmPush(this);
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x0009F742 File Offset: 0x0009D942
		// (set) Token: 0x060040DF RID: 16607 RVA: 0x0009F74A File Offset: 0x0009D94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x0009F753 File Offset: 0x0009D953
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x0009F75B File Offset: 0x0009D95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0009F764 File Offset: 0x0009D964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmPush);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0009F772 File Offset: 0x0009D972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmPush other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x0009F7B0 File Offset: 0x0009D9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x0009F808 File Offset: 0x0009DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0009F815 File Offset: 0x0009DA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0009F820 File Offset: 0x0009DA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.State);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x0009F87C File Offset: 0x0009DA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x0009F8D4 File Offset: 0x0009DAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0009F924 File Offset: 0x0009DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0009F930 File Offset: 0x0009DB30
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DD3 RID: 11731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD4 RID: 11732
		public const int FsmIdFieldNumber = 12;

		// Token: 0x04002DD5 RID: 11733
		private int fsmId_;

		// Token: 0x04002DD6 RID: 11734
		public const int StateFieldNumber = 5;

		// Token: 0x04002DD7 RID: 11735
		private int state_;
	}
}
