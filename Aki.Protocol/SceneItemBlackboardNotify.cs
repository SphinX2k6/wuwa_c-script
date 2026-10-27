using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001161 RID: 4449
	[NetMessage(EMessageId.SceneItemBlackboardNotify)]
	public sealed class SceneItemBlackboardNotify : IMessage<SceneItemBlackboardNotify>, IMessage, IEquatable<SceneItemBlackboardNotify>, IDeepCloneable<SceneItemBlackboardNotify>, IBufferMessage
	{
		// Token: 0x06017B79 RID: 97145 RVA: 0x00371C94 File Offset: 0x0036FE94
		[NullableContext(1)]
		public static SceneItemBlackboardNotify Create()
		{
			return new SceneItemBlackboardNotify();
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x06017B7A RID: 97146 RVA: 0x00371C9B File Offset: 0x0036FE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x06017B7B RID: 97147 RVA: 0x00371C9E File Offset: 0x0036FE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x06017B7C RID: 97148 RVA: 0x00371CA5 File Offset: 0x0036FEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify()
		{
		}

		// Token: 0x06017B7D RID: 97149 RVA: 0x00371CB8 File Offset: 0x0036FEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify(SceneItemBlackboardNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this.fullUpdate_ = other.fullUpdate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B7E RID: 97150 RVA: 0x00371D05 File Offset: 0x0036FF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardNotify Clone()
		{
			return new SceneItemBlackboardNotify(this);
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x06017B7F RID: 97151 RVA: 0x00371D0D File Offset: 0x0036FF0D
		// (set) Token: 0x06017B80 RID: 97152 RVA: 0x00371D15 File Offset: 0x0036FF15
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

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x06017B81 RID: 97153 RVA: 0x00371D1E File Offset: 0x0036FF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x06017B82 RID: 97154 RVA: 0x00371D26 File Offset: 0x0036FF26
		// (set) Token: 0x06017B83 RID: 97155 RVA: 0x00371D2E File Offset: 0x0036FF2E
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

		// Token: 0x06017B84 RID: 97156 RVA: 0x00371D37 File Offset: 0x0036FF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemBlackboardNotify);
		}

		// Token: 0x06017B85 RID: 97157 RVA: 0x00371D48 File Offset: 0x0036FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemBlackboardNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && this.FullUpdate == other.FullUpdate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B86 RID: 97158 RVA: 0x00371DA8 File Offset: 0x0036FFA8
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

		// Token: 0x06017B87 RID: 97159 RVA: 0x00371E0E File Offset: 0x0037000E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B88 RID: 97160 RVA: 0x00371E1B File Offset: 0x0037001B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B89 RID: 97161 RVA: 0x00371E24 File Offset: 0x00370024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.FullUpdate)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FullUpdate);
			}
			this.params_.WriteTo(ref output, SceneItemBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B8A RID: 97162 RVA: 0x00371E90 File Offset: 0x00370090
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

		// Token: 0x06017B8B RID: 97163 RVA: 0x00371EF0 File Offset: 0x003700F0
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

		// Token: 0x06017B8C RID: 97164 RVA: 0x00371F51 File Offset: 0x00370151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B8D RID: 97165 RVA: 0x00371F5C File Offset: 0x0037015C
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.params_.AddEntriesFrom(ref input, SceneItemBlackboardNotify._repeated_params_codec);
						}
					}
					else
					{
						this.FullUpdate = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008CCF RID: 36047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CD0 RID: 36048
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04008CD1 RID: 36049
		private long entityId_;

		// Token: 0x04008CD2 RID: 36050
		public const int ParamsFieldNumber = 11;

		// Token: 0x04008CD3 RID: 36051
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(90U, SceneItemBlackboardParam.Parser);

		// Token: 0x04008CD4 RID: 36052
		private readonly RepeatedField<SceneItemBlackboardParam> params_ = new RepeatedField<SceneItemBlackboardParam>();

		// Token: 0x04008CD5 RID: 36053
		public const int FullUpdateFieldNumber = 3;

		// Token: 0x04008CD6 RID: 36054
		private bool fullUpdate_;
	}
}
