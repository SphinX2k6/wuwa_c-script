using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001293 RID: 4755
	public sealed class StateTagComponentPb : IMessage<StateTagComponentPb>, IMessage, IEquatable<StateTagComponentPb>, IDeepCloneable<StateTagComponentPb>, IBufferMessage
	{
		// Token: 0x06019514 RID: 103700 RVA: 0x003AE7C2 File Offset: 0x003AC9C2
		[NullableContext(1)]
		public static StateTagComponentPb Create()
		{
			return new StateTagComponentPb();
		}

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x06019515 RID: 103701 RVA: 0x003AE7C9 File Offset: 0x003AC9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x06019516 RID: 103702 RVA: 0x003AE7CC File Offset: 0x003AC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateTagComponentPb.Descriptor;
			}
		}

		// Token: 0x06019517 RID: 103703 RVA: 0x003AE7D3 File Offset: 0x003AC9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb()
		{
		}

		// Token: 0x06019518 RID: 103704 RVA: 0x003AE7DB File Offset: 0x003AC9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb(StateTagComponentPb other) : this()
		{
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019519 RID: 103705 RVA: 0x003AE800 File Offset: 0x003ACA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb Clone()
		{
			return new StateTagComponentPb(this);
		}

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x0601951A RID: 103706 RVA: 0x003AE808 File Offset: 0x003ACA08
		// (set) Token: 0x0601951B RID: 103707 RVA: 0x003AE810 File Offset: 0x003ACA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x0601951C RID: 103708 RVA: 0x003AE819 File Offset: 0x003ACA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateTagComponentPb);
		}

		// Token: 0x0601951D RID: 103709 RVA: 0x003AE827 File Offset: 0x003ACA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateTagComponentPb other)
		{
			return other != null && (other == this || (this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601951E RID: 103710 RVA: 0x003AE858 File Offset: 0x003ACA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601951F RID: 103711 RVA: 0x003AE897 File Offset: 0x003ACA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019520 RID: 103712 RVA: 0x003AE8A4 File Offset: 0x003ACAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019521 RID: 103713 RVA: 0x003AE8AD File Offset: 0x003ACAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019522 RID: 103714 RVA: 0x003AE8E0 File Offset: 0x003ACAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019523 RID: 103715 RVA: 0x003AE91E File Offset: 0x003ACB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StateTagComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019524 RID: 103716 RVA: 0x003AE94F File Offset: 0x003ACB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019525 RID: 103717 RVA: 0x003AE958 File Offset: 0x003ACB58
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
					this.StateTagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094D0 RID: 38096
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094D1 RID: 38097
		public const int StateTagIdFieldNumber = 1;

		// Token: 0x040094D2 RID: 38098
		private int stateTagId_;
	}
}
