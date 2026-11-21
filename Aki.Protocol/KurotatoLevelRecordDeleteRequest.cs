using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000891 RID: 2193
	[NetMessage(EMessageId.KurotatoLevelRecordDeleteRequest)]
	public sealed class KurotatoLevelRecordDeleteRequest : IMessage<KurotatoLevelRecordDeleteRequest>, IMessage, IEquatable<KurotatoLevelRecordDeleteRequest>, IDeepCloneable<KurotatoLevelRecordDeleteRequest>, IBufferMessage
	{
		// Token: 0x0600C346 RID: 49990 RVA: 0x001CF9AE File Offset: 0x001CDBAE
		[NullableContext(1)]
		public static KurotatoLevelRecordDeleteRequest Create()
		{
			return new KurotatoLevelRecordDeleteRequest();
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600C347 RID: 49991 RVA: 0x001CF9B5 File Offset: 0x001CDBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600C348 RID: 49992 RVA: 0x001CF9B8 File Offset: 0x001CDBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelRecordDeleteRequest.Descriptor;
			}
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x001CF9BF File Offset: 0x001CDBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest()
		{
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x001CF9C7 File Offset: 0x001CDBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest(KurotatoLevelRecordDeleteRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x001CF9EC File Offset: 0x001CDBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteRequest Clone()
		{
			return new KurotatoLevelRecordDeleteRequest(this);
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600C34C RID: 49996 RVA: 0x001CF9F4 File Offset: 0x001CDBF4
		// (set) Token: 0x0600C34D RID: 49997 RVA: 0x001CF9FC File Offset: 0x001CDBFC
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

		// Token: 0x0600C34E RID: 49998 RVA: 0x001CFA05 File Offset: 0x001CDC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelRecordDeleteRequest);
		}

		// Token: 0x0600C34F RID: 49999 RVA: 0x001CFA13 File Offset: 0x001CDC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelRecordDeleteRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C350 RID: 50000 RVA: 0x001CFA44 File Offset: 0x001CDC44
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

		// Token: 0x0600C351 RID: 50001 RVA: 0x001CFA83 File Offset: 0x001CDC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x001CFA90 File Offset: 0x001CDC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C353 RID: 50003 RVA: 0x001CFA99 File Offset: 0x001CDC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C354 RID: 50004 RVA: 0x001CFACC File Offset: 0x001CDCCC
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

		// Token: 0x0600C355 RID: 50005 RVA: 0x001CFB0A File Offset: 0x001CDD0A
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

		// Token: 0x0600C356 RID: 50006 RVA: 0x001CFB3B File Offset: 0x001CDD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x001CFB44 File Offset: 0x001CDD44
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054C2 RID: 21698
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C3 RID: 21699
		public const int LevelIdFieldNumber = 5;

		// Token: 0x040054C4 RID: 21700
		private int levelId_;
	}
}
