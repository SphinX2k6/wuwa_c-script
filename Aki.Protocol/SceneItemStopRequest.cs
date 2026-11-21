using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B4 RID: 4532
	[NetMessage(EMessageId.SceneItemStopRequest)]
	public sealed class SceneItemStopRequest : IMessage<SceneItemStopRequest>, IMessage, IEquatable<SceneItemStopRequest>, IDeepCloneable<SceneItemStopRequest>, IBufferMessage
	{
		// Token: 0x06018334 RID: 99124 RVA: 0x00385EBE File Offset: 0x003840BE
		[NullableContext(1)]
		public static SceneItemStopRequest Create()
		{
			return new SceneItemStopRequest();
		}

		// Token: 0x17005188 RID: 20872
		// (get) Token: 0x06018335 RID: 99125 RVA: 0x00385EC5 File Offset: 0x003840C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x06018336 RID: 99126 RVA: 0x00385EC8 File Offset: 0x003840C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopRequest.Descriptor;
			}
		}

		// Token: 0x06018337 RID: 99127 RVA: 0x00385ECF File Offset: 0x003840CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest()
		{
		}

		// Token: 0x06018338 RID: 99128 RVA: 0x00385EE2 File Offset: 0x003840E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest(SceneItemStopRequest other) : this()
		{
			this.stopInfos_ = other.stopInfos_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018339 RID: 99129 RVA: 0x00385F18 File Offset: 0x00384118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest Clone()
		{
			return new SceneItemStopRequest(this);
		}

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x0601833A RID: 99130 RVA: 0x00385F20 File Offset: 0x00384120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemStopInfo> StopInfos
		{
			get
			{
				return this.stopInfos_;
			}
		}

		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x0601833B RID: 99131 RVA: 0x00385F28 File Offset: 0x00384128
		// (set) Token: 0x0601833C RID: 99132 RVA: 0x00385F30 File Offset: 0x00384130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneOwnerId
		{
			get
			{
				return this.sceneOwnerId_;
			}
			set
			{
				this.sceneOwnerId_ = value;
			}
		}

		// Token: 0x0601833D RID: 99133 RVA: 0x00385F39 File Offset: 0x00384139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopRequest);
		}

		// Token: 0x0601833E RID: 99134 RVA: 0x00385F48 File Offset: 0x00384148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopRequest other)
		{
			return other != null && (other == this || (this.stopInfos_.Equals(other.stopInfos_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x00385F98 File Offset: 0x00384198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stopInfos_.GetHashCode();
			if (this.SceneOwnerId != 0)
			{
				num ^= this.SceneOwnerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018340 RID: 99136 RVA: 0x00385FE5 File Offset: 0x003841E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018341 RID: 99137 RVA: 0x00385FF2 File Offset: 0x003841F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018342 RID: 99138 RVA: 0x00385FFC File Offset: 0x003841FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stopInfos_.WriteTo(ref output, SceneItemStopRequest._repeated_stopInfos_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018343 RID: 99139 RVA: 0x0038604C File Offset: 0x0038424C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stopInfos_.CalculateSize(SceneItemStopRequest._repeated_stopInfos_codec);
			if (this.SceneOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018344 RID: 99140 RVA: 0x003860A0 File Offset: 0x003842A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStopRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stopInfos_.Add(other.stopInfos_);
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018345 RID: 99141 RVA: 0x003860ED File Offset: 0x003842ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018346 RID: 99142 RVA: 0x003860F8 File Offset: 0x003842F8
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
				if (num != 50U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SceneOwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.stopInfos_.AddEntriesFrom(ref input, SceneItemStopRequest._repeated_stopInfos_codec);
				}
			}
		}

		// Token: 0x04008FF1 RID: 36849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FF2 RID: 36850
		public const int StopInfosFieldNumber = 6;

		// Token: 0x04008FF3 RID: 36851
		private static readonly FieldCodec<SceneItemStopInfo> _repeated_stopInfos_codec = FieldCodec.ForMessage<SceneItemStopInfo>(50U, SceneItemStopInfo.Parser);

		// Token: 0x04008FF4 RID: 36852
		private readonly RepeatedField<SceneItemStopInfo> stopInfos_ = new RepeatedField<SceneItemStopInfo>();

		// Token: 0x04008FF5 RID: 36853
		public const int SceneOwnerIdFieldNumber = 7;

		// Token: 0x04008FF6 RID: 36854
		private int sceneOwnerId_;
	}
}
