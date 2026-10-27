using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A8 RID: 1704
	[NetMessage(EMessageId.GameplayCueRequest)]
	public sealed class GameplayCueRequest : IMessage<GameplayCueRequest>, IMessage, IEquatable<GameplayCueRequest>, IDeepCloneable<GameplayCueRequest>, IBufferMessage
	{
		// Token: 0x06009C6A RID: 40042 RVA: 0x0017CD79 File Offset: 0x0017AF79
		[NullableContext(1)]
		public static GameplayCueRequest Create()
		{
			return new GameplayCueRequest();
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x0017CD80 File Offset: 0x0017AF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x0017CD83 File Offset: 0x0017AF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueRequest.Descriptor;
			}
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x0017CD8A File Offset: 0x0017AF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest()
		{
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x0017CD92 File Offset: 0x0017AF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest(GameplayCueRequest other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x0017CDB7 File Offset: 0x0017AFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest Clone()
		{
			return new GameplayCueRequest(this);
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06009C70 RID: 40048 RVA: 0x0017CDBF File Offset: 0x0017AFBF
		// (set) Token: 0x06009C71 RID: 40049 RVA: 0x0017CDC7 File Offset: 0x0017AFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CueConfigId
		{
			get
			{
				return this.cueConfigId_;
			}
			set
			{
				this.cueConfigId_ = value;
			}
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x0017CDD0 File Offset: 0x0017AFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueRequest);
		}

		// Token: 0x06009C73 RID: 40051 RVA: 0x0017CDDE File Offset: 0x0017AFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueRequest other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x0017CE0C File Offset: 0x0017B00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CueConfigId != 0L)
			{
				num ^= this.CueConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x0017CE4B File Offset: 0x0017B04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x0017CE58 File Offset: 0x0017B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x0017CE61 File Offset: 0x0017B061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x0017CE94 File Offset: 0x0017B094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CueConfigId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x0017CED2 File Offset: 0x0017B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCueRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CueConfigId != 0L)
			{
				this.CueConfigId = other.CueConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x0017CF03 File Offset: 0x0017B103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x0017CF0C File Offset: 0x0017B10C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049C3 RID: 18883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C4 RID: 18884
		public const int CueConfigIdFieldNumber = 4;

		// Token: 0x040049C5 RID: 18885
		private long cueConfigId_;
	}
}
