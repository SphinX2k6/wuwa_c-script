using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A2 RID: 2210
	[NetMessage(EMessageId.KurotatoLevelRecordDeleteRequest)]
	public sealed class KurotatoLevelRecordDeleteRequest : IMessage<KurotatoLevelRecordDeleteRequest>, IMessage, IEquatable<KurotatoLevelRecordDeleteRequest>, IDeepCloneable<KurotatoLevelRecordDeleteRequest>, IBufferMessage
	{
		// Token: 0x0600C462 RID: 50274 RVA: 0x001D1C92 File Offset: 0x001CFE92
		[NullableContext(1)]
		public static KurotatoLevelRecordDeleteRequest Create()
		{
			return new KurotatoLevelRecordDeleteRequest();
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600C463 RID: 50275 RVA: 0x001D1C99 File Offset: 0x001CFE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600C464 RID: 50276 RVA: 0x001D1C9C File Offset: 0x001CFE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelRecordDeleteRequest.Descriptor;
			}
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x001D1CA3 File Offset: 0x001CFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest()
		{
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x001D1CAB File Offset: 0x001CFEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest(KurotatoLevelRecordDeleteRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x001D1CD0 File Offset: 0x001CFED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest Clone()
		{
			return new KurotatoLevelRecordDeleteRequest(this);
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600C468 RID: 50280 RVA: 0x001D1CD8 File Offset: 0x001CFED8
		// (set) Token: 0x0600C469 RID: 50281 RVA: 0x001D1CE0 File Offset: 0x001CFEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x001D1CE9 File Offset: 0x001CFEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelRecordDeleteRequest);
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x001D1CF7 File Offset: 0x001CFEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelRecordDeleteRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x001D1D28 File Offset: 0x001CFF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x001D1D67 File Offset: 0x001CFF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x001D1D74 File Offset: 0x001CFF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x001D1D7D File Offset: 0x001CFF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C470 RID: 50288 RVA: 0x001D1DB0 File Offset: 0x001CFFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x001D1DEE File Offset: 0x001CFFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLevelRecordDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x001D1E1F File Offset: 0x001D001F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x001D1E28 File Offset: 0x001D0028
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054BB RID: 21691
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054BC RID: 21692
		public const int LevelIdFieldNumber = 15;

		// Token: 0x040054BD RID: 21693
		private int levelId_;
	}
}
