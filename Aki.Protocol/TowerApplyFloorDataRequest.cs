using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001409 RID: 5129
	[NetMessage(EMessageId.TowerApplyFloorDataRequest)]
	public sealed class TowerApplyFloorDataRequest : IMessage<TowerApplyFloorDataRequest>, IMessage, IEquatable<TowerApplyFloorDataRequest>, IDeepCloneable<TowerApplyFloorDataRequest>, IBufferMessage
	{
		// Token: 0x0601B43D RID: 111677 RVA: 0x003F7369 File Offset: 0x003F5569
		[NullableContext(1)]
		public static TowerApplyFloorDataRequest Create()
		{
			return new TowerApplyFloorDataRequest();
		}

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x0601B43E RID: 111678 RVA: 0x003F7370 File Offset: 0x003F5570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x0601B43F RID: 111679 RVA: 0x003F7373 File Offset: 0x003F5573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerApplyFloorDataRequest.Descriptor;
			}
		}

		// Token: 0x0601B440 RID: 111680 RVA: 0x003F737A File Offset: 0x003F557A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest()
		{
		}

		// Token: 0x0601B441 RID: 111681 RVA: 0x003F7382 File Offset: 0x003F5582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest(TowerApplyFloorDataRequest other) : this()
		{
			this.apply_ = other.apply_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B442 RID: 111682 RVA: 0x003F73A7 File Offset: 0x003F55A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest Clone()
		{
			return new TowerApplyFloorDataRequest(this);
		}

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x0601B443 RID: 111683 RVA: 0x003F73AF File Offset: 0x003F55AF
		// (set) Token: 0x0601B444 RID: 111684 RVA: 0x003F73B7 File Offset: 0x003F55B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Apply
		{
			get
			{
				return this.apply_;
			}
			set
			{
				this.apply_ = value;
			}
		}

		// Token: 0x0601B445 RID: 111685 RVA: 0x003F73C0 File Offset: 0x003F55C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerApplyFloorDataRequest);
		}

		// Token: 0x0601B446 RID: 111686 RVA: 0x003F73CE File Offset: 0x003F55CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerApplyFloorDataRequest other)
		{
			return other != null && (other == this || (this.Apply == other.Apply && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B447 RID: 111687 RVA: 0x003F73FC File Offset: 0x003F55FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Apply)
			{
				num ^= this.Apply.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B448 RID: 111688 RVA: 0x003F743B File Offset: 0x003F563B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B449 RID: 111689 RVA: 0x003F7448 File Offset: 0x003F5648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B44A RID: 111690 RVA: 0x003F7451 File Offset: 0x003F5651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Apply)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Apply);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B44B RID: 111691 RVA: 0x003F7484 File Offset: 0x003F5684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Apply)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B44C RID: 111692 RVA: 0x003F74B6 File Offset: 0x003F56B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerApplyFloorDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Apply)
			{
				this.Apply = other.Apply;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B44D RID: 111693 RVA: 0x003F74E7 File Offset: 0x003F56E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B44E RID: 111694 RVA: 0x003F74F0 File Offset: 0x003F56F0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Apply = input.ReadBool();
				}
			}
		}

		// Token: 0x04009EE2 RID: 40674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EE3 RID: 40675
		public const int ApplyFieldNumber = 3;

		// Token: 0x04009EE4 RID: 40676
		private bool apply_;
	}
}
