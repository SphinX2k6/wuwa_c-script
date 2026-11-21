using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000647 RID: 1607
	public sealed class FRMixAction : IMessage<FRMixAction>, IMessage, IEquatable<FRMixAction>, IDeepCloneable<FRMixAction>, IBufferMessage
	{
		// Token: 0x06009412 RID: 37906 RVA: 0x0016601D File Offset: 0x0016421D
		[NullableContext(1)]
		public static FRMixAction Create()
		{
			return new FRMixAction();
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x00166024 File Offset: 0x00164224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06009414 RID: 37908 RVA: 0x00166027 File Offset: 0x00164227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRMixAction.Descriptor;
			}
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x0016602E File Offset: 0x0016422E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction()
		{
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00166044 File Offset: 0x00164244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction(FRMixAction other) : this()
		{
			this.targetUnit_ = ((other.targetUnit_ != null) ? other.targetUnit_.Clone() : null);
			this.mixMaterialIncId_ = other.mixMaterialIncId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00166095 File Offset: 0x00164295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction Clone()
		{
			return new FRMixAction(this);
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x0016609D File Offset: 0x0016429D
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x001660A5 File Offset: 0x001642A5
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

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x001660AE File Offset: 0x001642AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MixMaterialIncId
		{
			get
			{
				return this.mixMaterialIncId_;
			}
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x001660B6 File Offset: 0x001642B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRMixAction);
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x001660C4 File Offset: 0x001642C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRMixAction other)
		{
			return other != null && (other == this || (object.Equals(this.TargetUnit, other.TargetUnit) && this.mixMaterialIncId_.Equals(other.mixMaterialIncId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00166118 File Offset: 0x00164318
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

		// Token: 0x0600941E RID: 37918 RVA: 0x00166162 File Offset: 0x00164362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x0016616F File Offset: 0x0016436F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00166178 File Offset: 0x00164378
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

		// Token: 0x06009421 RID: 37921 RVA: 0x001661C8 File Offset: 0x001643C8
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

		// Token: 0x06009422 RID: 37922 RVA: 0x0016621C File Offset: 0x0016441C
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

		// Token: 0x06009423 RID: 37923 RVA: 0x00166281 File Offset: 0x00164481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x0016628C File Offset: 0x0016448C
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

		// Token: 0x0400475A RID: 18266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400475B RID: 18267
		public const int TargetUnitFieldNumber = 1;

		// Token: 0x0400475C RID: 18268
		private FloroRanchPlayUnit targetUnit_;

		// Token: 0x0400475D RID: 18269
		public const int MixMaterialIncIdFieldNumber = 2;

		// Token: 0x0400475E RID: 18270
		private static readonly FieldCodec<int> _repeated_mixMaterialIncId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400475F RID: 18271
		private readonly RepeatedField<int> mixMaterialIncId_ = new RepeatedField<int>();
	}
}
