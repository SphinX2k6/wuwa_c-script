using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F7 RID: 247
	public sealed class AnimStateChangeInfoList : IMessage<AnimStateChangeInfoList>, IMessage, IEquatable<AnimStateChangeInfoList>, IDeepCloneable<AnimStateChangeInfoList>, IBufferMessage
	{
		// Token: 0x0600231F RID: 8991 RVA: 0x0005DAA5 File Offset: 0x0005BCA5
		[NullableContext(1)]
		public static AnimStateChangeInfoList Create()
		{
			return new AnimStateChangeInfoList();
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0005DAAC File Offset: 0x0005BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AnimStateChangeInfoList> Parser
		{
			get
			{
				return AnimStateChangeInfoList._parser;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0005DAB3 File Offset: 0x0005BCB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0005DAB6 File Offset: 0x0005BCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimStateChangeInfoList.Descriptor;
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0005DABD File Offset: 0x0005BCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList()
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList(AnimStateChangeInfoList other) : this()
		{
			this.entityId_ = other.entityId_;
			this.animStateChangeInfos_ = other.animStateChangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0005DB06 File Offset: 0x0005BD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList Clone()
		{
			return new AnimStateChangeInfoList(this);
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0005DB0E File Offset: 0x0005BD0E
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0005DB16 File Offset: 0x0005BD16
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0005DB1F File Offset: 0x0005BD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AnimStateChangeInfo> AnimStateChangeInfos
		{
			get
			{
				return this.animStateChangeInfos_;
			}
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0005DB27 File Offset: 0x0005BD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimStateChangeInfoList);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0005DB38 File Offset: 0x0005BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimStateChangeInfoList other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.animStateChangeInfos_.Equals(other.animStateChangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0005DB88 File Offset: 0x0005BD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.animStateChangeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0005DBD5 File Offset: 0x0005BDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0005DBE2 File Offset: 0x0005BDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0005DBEC File Offset: 0x0005BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.animStateChangeInfos_.WriteTo(ref output, AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0005DC3C File Offset: 0x0005BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.animStateChangeInfos_.CalculateSize(AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0005DC90 File Offset: 0x0005BE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimStateChangeInfoList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.animStateChangeInfos_.Add(other.animStateChangeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0005DCDD File Offset: 0x0005BEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0005DCE8 File Offset: 0x0005BEE8
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
						this.animStateChangeInfos_.AddEntriesFrom(ref input, AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040024D7 RID: 9431
		private static readonly MessageParser<AnimStateChangeInfoList> _parser = new MessageParser<AnimStateChangeInfoList>(() => new AnimStateChangeInfoList());

		// Token: 0x040024D8 RID: 9432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024D9 RID: 9433
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040024DA RID: 9434
		private long entityId_;

		// Token: 0x040024DB RID: 9435
		public const int AnimStateChangeInfosFieldNumber = 2;

		// Token: 0x040024DC RID: 9436
		private static readonly FieldCodec<AnimStateChangeInfo> _repeated_animStateChangeInfos_codec = FieldCodec.ForMessage<AnimStateChangeInfo>(18U, AnimStateChangeInfo.Parser);

		// Token: 0x040024DD RID: 9437
		private readonly RepeatedField<AnimStateChangeInfo> animStateChangeInfos_ = new RepeatedField<AnimStateChangeInfo>();
	}
}
