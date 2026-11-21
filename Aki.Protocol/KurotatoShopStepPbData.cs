using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BC RID: 2236
	public sealed class KurotatoShopStepPbData : IMessage<KurotatoShopStepPbData>, IMessage, IEquatable<KurotatoShopStepPbData>, IDeepCloneable<KurotatoShopStepPbData>, IBufferMessage
	{
		// Token: 0x0600C68A RID: 50826 RVA: 0x001D6337 File Offset: 0x001D4537
		[NullableContext(1)]
		public static KurotatoShopStepPbData Create()
		{
			return new KurotatoShopStepPbData();
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600C68B RID: 50827 RVA: 0x001D633E File Offset: 0x001D453E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600C68C RID: 50828 RVA: 0x001D6341 File Offset: 0x001D4541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x001D6348 File Offset: 0x001D4548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData()
		{
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x001D6350 File Offset: 0x001D4550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData(KurotatoShopStepPbData other) : this()
		{
			this.hasEndLessModeSelection_ = other.hasEndLessModeSelection_;
			this.nextWaveType_ = other.nextWaveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x001D6381 File Offset: 0x001D4581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData Clone()
		{
			return new KurotatoShopStepPbData(this);
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600C690 RID: 50832 RVA: 0x001D6389 File Offset: 0x001D4589
		// (set) Token: 0x0600C691 RID: 50833 RVA: 0x001D6391 File Offset: 0x001D4591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEndLessModeSelection
		{
			get
			{
				return this.hasEndLessModeSelection_;
			}
			set
			{
				this.hasEndLessModeSelection_ = value;
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600C692 RID: 50834 RVA: 0x001D639A File Offset: 0x001D459A
		// (set) Token: 0x0600C693 RID: 50835 RVA: 0x001D63A2 File Offset: 0x001D45A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveType NextWaveType
		{
			get
			{
				return this.nextWaveType_;
			}
			set
			{
				this.nextWaveType_ = value;
			}
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x001D63AB File Offset: 0x001D45AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopStepPbData);
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x001D63B9 File Offset: 0x001D45B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopStepPbData other)
		{
			return other != null && (other == this || (this.HasEndLessModeSelection == other.HasEndLessModeSelection && this.NextWaveType == other.NextWaveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C696 RID: 50838 RVA: 0x001D63F8 File Offset: 0x001D45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasEndLessModeSelection)
			{
				num ^= this.HasEndLessModeSelection.GetHashCode();
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num ^= this.NextWaveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C697 RID: 50839 RVA: 0x001D6456 File Offset: 0x001D4656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C698 RID: 50840 RVA: 0x001D6463 File Offset: 0x001D4663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C699 RID: 50841 RVA: 0x001D646C File Offset: 0x001D466C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasEndLessModeSelection)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasEndLessModeSelection);
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.NextWaveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C69A RID: 50842 RVA: 0x001D64C4 File Offset: 0x001D46C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasEndLessModeSelection)
			{
				num += 2;
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NextWaveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x001D6510 File Offset: 0x001D4710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasEndLessModeSelection)
			{
				this.HasEndLessModeSelection = other.HasEndLessModeSelection;
			}
			if (other.NextWaveType != KurotatoNextWaveType.Default)
			{
				this.NextWaveType = other.NextWaveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C69C RID: 50844 RVA: 0x001D6560 File Offset: 0x001D4760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x001D656C File Offset: 0x001D476C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextWaveType = (KurotatoNextWaveType)input.ReadEnum();
					}
				}
				else
				{
					this.HasEndLessModeSelection = input.ReadBool();
				}
			}
		}

		// Token: 0x0400558F RID: 21903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005590 RID: 21904
		public const int HasEndLessModeSelectionFieldNumber = 1;

		// Token: 0x04005591 RID: 21905
		private bool hasEndLessModeSelection_;

		// Token: 0x04005592 RID: 21906
		public const int NextWaveTypeFieldNumber = 2;

		// Token: 0x04005593 RID: 21907
		private KurotatoNextWaveType nextWaveType_;
	}
}
