using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117A RID: 4474
	[NetMessage(EMessageId.SceneItemStopRequest)]
	public sealed class SceneItemStopRequest : IMessage<SceneItemStopRequest>, IMessage, IEquatable<SceneItemStopRequest>, IDeepCloneable<SceneItemStopRequest>, IBufferMessage
	{
		// Token: 0x06017D93 RID: 97683 RVA: 0x00376B7A File Offset: 0x00374D7A
		[NullableContext(1)]
		public static SceneItemStopRequest Create()
		{
			return new SceneItemStopRequest();
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x06017D94 RID: 97684 RVA: 0x00376B81 File Offset: 0x00374D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x06017D95 RID: 97685 RVA: 0x00376B84 File Offset: 0x00374D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopRequest.Descriptor;
			}
		}

		// Token: 0x06017D96 RID: 97686 RVA: 0x00376B8B File Offset: 0x00374D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest()
		{
		}

		// Token: 0x06017D97 RID: 97687 RVA: 0x00376B9E File Offset: 0x00374D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest(SceneItemStopRequest other) : this()
		{
			this.stopInfos_ = other.stopInfos_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D98 RID: 97688 RVA: 0x00376BD4 File Offset: 0x00374DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopRequest Clone()
		{
			return new SceneItemStopRequest(this);
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x06017D99 RID: 97689 RVA: 0x00376BDC File Offset: 0x00374DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemStopInfo> StopInfos
		{
			get
			{
				return this.stopInfos_;
			}
		}

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x06017D9A RID: 97690 RVA: 0x00376BE4 File Offset: 0x00374DE4
		// (set) Token: 0x06017D9B RID: 97691 RVA: 0x00376BEC File Offset: 0x00374DEC
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

		// Token: 0x06017D9C RID: 97692 RVA: 0x00376BF5 File Offset: 0x00374DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopRequest);
		}

		// Token: 0x06017D9D RID: 97693 RVA: 0x00376C04 File Offset: 0x00374E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopRequest other)
		{
			return other != null && (other == this || (this.stopInfos_.Equals(other.stopInfos_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D9E RID: 97694 RVA: 0x00376C54 File Offset: 0x00374E54
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

		// Token: 0x06017D9F RID: 97695 RVA: 0x00376CA1 File Offset: 0x00374EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DA0 RID: 97696 RVA: 0x00376CAE File Offset: 0x00374EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DA1 RID: 97697 RVA: 0x00376CB8 File Offset: 0x00374EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stopInfos_.WriteTo(ref output, SceneItemStopRequest._repeated_stopInfos_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DA2 RID: 97698 RVA: 0x00376D08 File Offset: 0x00374F08
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

		// Token: 0x06017DA3 RID: 97699 RVA: 0x00376D5C File Offset: 0x00374F5C
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

		// Token: 0x06017DA4 RID: 97700 RVA: 0x00376DA9 File Offset: 0x00374FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DA5 RID: 97701 RVA: 0x00376DB4 File Offset: 0x00374FB4
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
				if (num != 82U)
				{
					if (num != 88U)
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

		// Token: 0x04008D5E RID: 36190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D5F RID: 36191
		public const int StopInfosFieldNumber = 10;

		// Token: 0x04008D60 RID: 36192
		private static readonly FieldCodec<SceneItemStopInfo> _repeated_stopInfos_codec = FieldCodec.ForMessage<SceneItemStopInfo>(82U, SceneItemStopInfo.Parser);

		// Token: 0x04008D61 RID: 36193
		private readonly RepeatedField<SceneItemStopInfo> stopInfos_ = new RepeatedField<SceneItemStopInfo>();

		// Token: 0x04008D62 RID: 36194
		public const int SceneOwnerIdFieldNumber = 11;

		// Token: 0x04008D63 RID: 36195
		private int sceneOwnerId_;
	}
}
