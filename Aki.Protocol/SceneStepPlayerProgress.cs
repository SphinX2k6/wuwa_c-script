using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118D RID: 4493
	public sealed class SceneStepPlayerProgress : IMessage<SceneStepPlayerProgress>, IMessage, IEquatable<SceneStepPlayerProgress>, IDeepCloneable<SceneStepPlayerProgress>, IBufferMessage
	{
		// Token: 0x06017F2B RID: 98091 RVA: 0x0037A647 File Offset: 0x00378847
		[NullableContext(1)]
		public static SceneStepPlayerProgress Create()
		{
			return new SceneStepPlayerProgress();
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x06017F2C RID: 98092 RVA: 0x0037A64E File Offset: 0x0037884E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepPlayerProgress> Parser
		{
			get
			{
				return SceneStepPlayerProgress._parser;
			}
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x06017F2D RID: 98093 RVA: 0x0037A655 File Offset: 0x00378855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x06017F2E RID: 98094 RVA: 0x0037A658 File Offset: 0x00378858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepPlayerProgress.Descriptor;
			}
		}

		// Token: 0x06017F2F RID: 98095 RVA: 0x0037A65F File Offset: 0x0037885F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress()
		{
		}

		// Token: 0x06017F30 RID: 98096 RVA: 0x0037A672 File Offset: 0x00378872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress(SceneStepPlayerProgress other) : this()
		{
			this.playerId_ = other.playerId_;
			this.progress_ = other.progress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F31 RID: 98097 RVA: 0x0037A6A8 File Offset: 0x003788A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress Clone()
		{
			return new SceneStepPlayerProgress(this);
		}

		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x06017F32 RID: 98098 RVA: 0x0037A6B0 File Offset: 0x003788B0
		// (set) Token: 0x06017F33 RID: 98099 RVA: 0x0037A6B8 File Offset: 0x003788B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x06017F34 RID: 98100 RVA: 0x0037A6C1 File Offset: 0x003788C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepConditionProgress> Progress
		{
			get
			{
				return this.progress_;
			}
		}

		// Token: 0x06017F35 RID: 98101 RVA: 0x0037A6C9 File Offset: 0x003788C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepPlayerProgress);
		}

		// Token: 0x06017F36 RID: 98102 RVA: 0x0037A6D8 File Offset: 0x003788D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepPlayerProgress other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.progress_.Equals(other.progress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F37 RID: 98103 RVA: 0x0037A728 File Offset: 0x00378928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.progress_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F38 RID: 98104 RVA: 0x0037A775 File Offset: 0x00378975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F39 RID: 98105 RVA: 0x0037A782 File Offset: 0x00378982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F3A RID: 98106 RVA: 0x0037A78C File Offset: 0x0037898C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.progress_.WriteTo(ref output, SceneStepPlayerProgress._repeated_progress_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F3B RID: 98107 RVA: 0x0037A7DC File Offset: 0x003789DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.progress_.CalculateSize(SceneStepPlayerProgress._repeated_progress_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F3C RID: 98108 RVA: 0x0037A830 File Offset: 0x00378A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepPlayerProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.progress_.Add(other.progress_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F3D RID: 98109 RVA: 0x0037A87D File Offset: 0x00378A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F3E RID: 98110 RVA: 0x0037A888 File Offset: 0x00378A88
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.progress_.AddEntriesFrom(ref input, SceneStepPlayerProgress._repeated_progress_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DDE RID: 36318
		private static readonly MessageParser<SceneStepPlayerProgress> _parser = new MessageParser<SceneStepPlayerProgress>(() => new SceneStepPlayerProgress());

		// Token: 0x04008DDF RID: 36319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DE0 RID: 36320
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04008DE1 RID: 36321
		private int playerId_;

		// Token: 0x04008DE2 RID: 36322
		public const int ProgressFieldNumber = 2;

		// Token: 0x04008DE3 RID: 36323
		private static readonly FieldCodec<SceneStepConditionProgress> _repeated_progress_codec = FieldCodec.ForMessage<SceneStepConditionProgress>(18U, SceneStepConditionProgress.Parser);

		// Token: 0x04008DE4 RID: 36324
		private readonly RepeatedField<SceneStepConditionProgress> progress_ = new RepeatedField<SceneStepConditionProgress>();
	}
}
