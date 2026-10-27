using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065B RID: 1627
	public sealed class FRMixAction : IMessage<FRMixAction>, IMessage, IEquatable<FRMixAction>, IDeepCloneable<FRMixAction>, IBufferMessage
	{
		// Token: 0x06009568 RID: 38248 RVA: 0x00168A4C File Offset: 0x00166C4C
		[NullableContext(1)]
		public static FRMixAction Create()
		{
			return new FRMixAction();
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x00168A53 File Offset: 0x00166C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x0600956A RID: 38250 RVA: 0x00168A56 File Offset: 0x00166C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRMixAction.Descriptor;
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00168A5D File Offset: 0x00166C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction()
		{
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x00168A70 File Offset: 0x00166C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction(FRMixAction other) : this()
		{
			this.targetUnit_ = ((other.targetUnit_ != null) ? other.targetUnit_.Clone() : null);
			this.mixMaterialIncId_ = other.mixMaterialIncId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00168AC1 File Offset: 0x00166CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction Clone()
		{
			return new FRMixAction(this);
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600956E RID: 38254 RVA: 0x00168AC9 File Offset: 0x00166CC9
		// (set) Token: 0x0600956F RID: 38255 RVA: 0x00168AD1 File Offset: 0x00166CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit TargetUnit
		{
			get
			{
				return this.targetUnit_;
			}
			set
			{
				this.targetUnit_ = value;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06009570 RID: 38256 RVA: 0x00168ADA File Offset: 0x00166CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MixMaterialIncId
		{
			get
			{
				return this.mixMaterialIncId_;
			}
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x00168AE2 File Offset: 0x00166CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRMixAction);
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00168AF0 File Offset: 0x00166CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRMixAction other)
		{
			return other != null && (other == this || (object.Equals(this.TargetUnit, other.TargetUnit) && this.mixMaterialIncId_.Equals(other.mixMaterialIncId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x00168B44 File Offset: 0x00166D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetUnit_ != null)
			{
				num ^= this.TargetUnit.GetHashCode();
			}
			num ^= this.mixMaterialIncId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x00168B8E File Offset: 0x00166D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x00168B9B File Offset: 0x00166D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x00168BA4 File Offset: 0x00166DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetUnit_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetUnit);
			}
			this.mixMaterialIncId_.WriteTo(ref output, FRMixAction._repeated_mixMaterialIncId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x00168BF4 File Offset: 0x00166DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.targetUnit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetUnit);
			}
			num += this.mixMaterialIncId_.CalculateSize(FRMixAction._repeated_mixMaterialIncId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x00168C48 File Offset: 0x00166E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRMixAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.targetUnit_ != null)
			{
				if (this.targetUnit_ == null)
				{
					this.TargetUnit = new FloroRanchPlayUnit();
				}
				this.TargetUnit.MergeFrom(other.TargetUnit);
			}
			this.mixMaterialIncId_.Add(other.mixMaterialIncId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x00168CAD File Offset: 0x00166EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x00168CB8 File Offset: 0x00166EB8
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
				if (num != 10U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.mixMaterialIncId_.AddEntriesFrom(ref input, FRMixAction._repeated_mixMaterialIncId_codec);
					}
				}
				else
				{
					if (this.targetUnit_ == null)
					{
						this.TargetUnit = new FloroRanchPlayUnit();
					}
					input.ReadMessage(this.TargetUnit);
				}
			}
		}

		// Token: 0x04004761 RID: 18273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004762 RID: 18274
		public const int TargetUnitFieldNumber = 1;

		// Token: 0x04004763 RID: 18275
		private FloroRanchPlayUnit targetUnit_;

		// Token: 0x04004764 RID: 18276
		public const int MixMaterialIncIdFieldNumber = 2;

		// Token: 0x04004765 RID: 18277
		private static readonly FieldCodec<int> _repeated_mixMaterialIncId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004766 RID: 18278
		private readonly RepeatedField<int> mixMaterialIncId_ = new RepeatedField<int>();
	}
}
