using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C7 RID: 4551
	public sealed class SceneStepPlayerProgress : IMessage<SceneStepPlayerProgress>, IMessage, IEquatable<SceneStepPlayerProgress>, IDeepCloneable<SceneStepPlayerProgress>, IBufferMessage
	{
		// Token: 0x060184CC RID: 99532 RVA: 0x00389986 File Offset: 0x00387B86
		[NullableContext(1)]
		public static SceneStepPlayerProgress Create()
		{
			return new SceneStepPlayerProgress();
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x060184CD RID: 99533 RVA: 0x0038998D File Offset: 0x00387B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepPlayerProgress> Parser
		{
			get
			{
				return SceneStepPlayerProgress._parser;
			}
		}

		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x060184CE RID: 99534 RVA: 0x00389994 File Offset: 0x00387B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x060184CF RID: 99535 RVA: 0x00389997 File Offset: 0x00387B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepPlayerProgress.Descriptor;
			}
		}

		// Token: 0x060184D0 RID: 99536 RVA: 0x0038999E File Offset: 0x00387B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress()
		{
		}

		// Token: 0x060184D1 RID: 99537 RVA: 0x003899B1 File Offset: 0x00387BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress(SceneStepPlayerProgress other) : this()
		{
			this.playerId_ = other.playerId_;
			this.progress_ = other.progress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184D2 RID: 99538 RVA: 0x003899E7 File Offset: 0x00387BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepPlayerProgress Clone()
		{
			return new SceneStepPlayerProgress(this);
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x060184D3 RID: 99539 RVA: 0x003899EF File Offset: 0x00387BEF
		// (set) Token: 0x060184D4 RID: 99540 RVA: 0x003899F7 File Offset: 0x00387BF7
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

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x060184D5 RID: 99541 RVA: 0x00389A00 File Offset: 0x00387C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepConditionProgress> Progress
		{
			get
			{
				return this.progress_;
			}
		}

		// Token: 0x060184D6 RID: 99542 RVA: 0x00389A08 File Offset: 0x00387C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepPlayerProgress);
		}

		// Token: 0x060184D7 RID: 99543 RVA: 0x00389A18 File Offset: 0x00387C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepPlayerProgress other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.progress_.Equals(other.progress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184D8 RID: 99544 RVA: 0x00389A68 File Offset: 0x00387C68
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

		// Token: 0x060184D9 RID: 99545 RVA: 0x00389AB5 File Offset: 0x00387CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184DA RID: 99546 RVA: 0x00389AC2 File Offset: 0x00387CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184DB RID: 99547 RVA: 0x00389ACC File Offset: 0x00387CCC
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

		// Token: 0x060184DC RID: 99548 RVA: 0x00389B1C File Offset: 0x00387D1C
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

		// Token: 0x060184DD RID: 99549 RVA: 0x00389B70 File Offset: 0x00387D70
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

		// Token: 0x060184DE RID: 99550 RVA: 0x00389BBD File Offset: 0x00387DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184DF RID: 99551 RVA: 0x00389BC8 File Offset: 0x00387DC8
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

		// Token: 0x04009071 RID: 36977
		private static readonly MessageParser<SceneStepPlayerProgress> _parser = new MessageParser<SceneStepPlayerProgress>(() => new SceneStepPlayerProgress());

		// Token: 0x04009072 RID: 36978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009073 RID: 36979
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04009074 RID: 36980
		private int playerId_;

		// Token: 0x04009075 RID: 36981
		public const int ProgressFieldNumber = 2;

		// Token: 0x04009076 RID: 36982
		private static readonly FieldCodec<SceneStepConditionProgress> _repeated_progress_codec = FieldCodec.ForMessage<SceneStepConditionProgress>(18U, SceneStepConditionProgress.Parser);

		// Token: 0x04009077 RID: 36983
		private readonly RepeatedField<SceneStepConditionProgress> progress_ = new RepeatedField<SceneStepConditionProgress>();
	}
}
