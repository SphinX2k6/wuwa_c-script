using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119B RID: 4507
	[NetMessage(EMessageId.SceneItemBlackboardNotify)]
	public sealed class SceneItemBlackboardNotify : IMessage<SceneItemBlackboardNotify>, IMessage, IEquatable<SceneItemBlackboardNotify>, IDeepCloneable<SceneItemBlackboardNotify>, IBufferMessage
	{
		// Token: 0x0601811A RID: 98586 RVA: 0x00380FE4 File Offset: 0x0037F1E4
		[NullableContext(1)]
		public static SceneItemBlackboardNotify Create()
		{
			return new SceneItemBlackboardNotify();
		}

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x0601811B RID: 98587 RVA: 0x00380FEB File Offset: 0x0037F1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x0601811C RID: 98588 RVA: 0x00380FEE File Offset: 0x0037F1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x0601811D RID: 98589 RVA: 0x00380FF5 File Offset: 0x0037F1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify()
		{
		}

		// Token: 0x0601811E RID: 98590 RVA: 0x00381008 File Offset: 0x0037F208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify(SceneItemBlackboardNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this.fullUpdate_ = other.fullUpdate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601811F RID: 98591 RVA: 0x00381055 File Offset: 0x0037F255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify Clone()
		{
			return new SceneItemBlackboardNotify(this);
		}

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x06018120 RID: 98592 RVA: 0x0038105D File Offset: 0x0037F25D
		// (set) Token: 0x06018121 RID: 98593 RVA: 0x00381065 File Offset: 0x0037F265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x06018122 RID: 98594 RVA: 0x0038106E File Offset: 0x0037F26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x06018123 RID: 98595 RVA: 0x00381076 File Offset: 0x0037F276
		// (set) Token: 0x06018124 RID: 98596 RVA: 0x0038107E File Offset: 0x0037F27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FullUpdate
		{
			get
			{
				return this.fullUpdate_;
			}
			set
			{
				this.fullUpdate_ = value;
			}
		}

		// Token: 0x06018125 RID: 98597 RVA: 0x00381087 File Offset: 0x0037F287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemBlackboardNotify);
		}

		// Token: 0x06018126 RID: 98598 RVA: 0x00381098 File Offset: 0x0037F298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemBlackboardNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && this.FullUpdate == other.FullUpdate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018127 RID: 98599 RVA: 0x003810F8 File Offset: 0x0037F2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.params_.GetHashCode();
			if (this.FullUpdate)
			{
				num ^= this.FullUpdate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018128 RID: 98600 RVA: 0x0038115E File Offset: 0x0037F35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018129 RID: 98601 RVA: 0x0038116B File Offset: 0x0037F36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601812A RID: 98602 RVA: 0x00381174 File Offset: 0x0037F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			this.params_.WriteTo(ref output, SceneItemBlackboardNotify._repeated_params_codec);
			if (this.FullUpdate)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.FullUpdate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601812B RID: 98603 RVA: 0x003811E0 File Offset: 0x0037F3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.params_.CalculateSize(SceneItemBlackboardNotify._repeated_params_codec);
			if (this.FullUpdate)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601812C RID: 98604 RVA: 0x00381240 File Offset: 0x0037F440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.params_.Add(other.params_);
			if (other.FullUpdate)
			{
				this.FullUpdate = other.FullUpdate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601812D RID: 98605 RVA: 0x003812A1 File Offset: 0x0037F4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601812E RID: 98606 RVA: 0x003812AC File Offset: 0x0037F4AC
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
				if (num != 48U)
				{
					if (num != 58U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FullUpdate = input.ReadBool();
						}
					}
					else
					{
						this.params_.AddEntriesFrom(ref input, SceneItemBlackboardNotify._repeated_params_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F62 RID: 36706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F63 RID: 36707
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04008F64 RID: 36708
		private long entityId_;

		// Token: 0x04008F65 RID: 36709
		public const int ParamsFieldNumber = 7;

		// Token: 0x04008F66 RID: 36710
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(58U, SceneItemBlackboardParam.Parser);

		// Token: 0x04008F67 RID: 36711
		private readonly RepeatedField<SceneItemBlackboardParam> params_ = new RepeatedField<SceneItemBlackboardParam>();

		// Token: 0x04008F68 RID: 36712
		public const int FullUpdateFieldNumber = 14;

		// Token: 0x04008F69 RID: 36713
		private bool fullUpdate_;
	}
}
