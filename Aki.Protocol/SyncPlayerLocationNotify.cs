using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001375 RID: 4981
	[NetMessage(EMessageId.SyncPlayerLocationNotify)]
	public sealed class SyncPlayerLocationNotify : IMessage<SyncPlayerLocationNotify>, IMessage, IEquatable<SyncPlayerLocationNotify>, IDeepCloneable<SyncPlayerLocationNotify>, IBufferMessage
	{
		// Token: 0x0601A866 RID: 108646 RVA: 0x003DD680 File Offset: 0x003DB880
		[NullableContext(1)]
		public static SyncPlayerLocationNotify Create()
		{
			return new SyncPlayerLocationNotify();
		}

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x0601A867 RID: 108647 RVA: 0x003DD687 File Offset: 0x003DB887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x0601A868 RID: 108648 RVA: 0x003DD68A File Offset: 0x003DB88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncPlayerLocationNotify.Descriptor;
			}
		}

		// Token: 0x0601A869 RID: 108649 RVA: 0x003DD691 File Offset: 0x003DB891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify()
		{
		}

		// Token: 0x0601A86A RID: 108650 RVA: 0x003DD6A4 File Offset: 0x003DB8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify(SyncPlayerLocationNotify other) : this()
		{
			this.locationList_ = other.locationList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A86B RID: 108651 RVA: 0x003DD6CE File Offset: 0x003DB8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify Clone()
		{
			return new SyncPlayerLocationNotify(this);
		}

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x0601A86C RID: 108652 RVA: 0x003DD6D6 File Offset: 0x003DB8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerLocation> LocationList
		{
			get
			{
				return this.locationList_;
			}
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x003DD6DE File Offset: 0x003DB8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncPlayerLocationNotify);
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x003DD6EC File Offset: 0x003DB8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncPlayerLocationNotify other)
		{
			return other != null && (other == this || (this.locationList_.Equals(other.locationList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x003DD720 File Offset: 0x003DB920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.locationList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A870 RID: 108656 RVA: 0x003DD754 File Offset: 0x003DB954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A871 RID: 108657 RVA: 0x003DD761 File Offset: 0x003DB961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A872 RID: 108658 RVA: 0x003DD76A File Offset: 0x003DB96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.locationList_.WriteTo(ref output, SyncPlayerLocationNotify._repeated_locationList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A873 RID: 108659 RVA: 0x003DD794 File Offset: 0x003DB994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.locationList_.CalculateSize(SyncPlayerLocationNotify._repeated_locationList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A874 RID: 108660 RVA: 0x003DD7CD File Offset: 0x003DB9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncPlayerLocationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.locationList_.Add(other.locationList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A875 RID: 108661 RVA: 0x003DD7FB File Offset: 0x003DB9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x003DD804 File Offset: 0x003DBA04
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.locationList_.AddEntriesFrom(ref input, SyncPlayerLocationNotify._repeated_locationList_codec);
				}
			}
		}

		// Token: 0x04009B83 RID: 39811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B84 RID: 39812
		public const int LocationListFieldNumber = 9;

		// Token: 0x04009B85 RID: 39813
		private static readonly FieldCodec<PlayerLocation> _repeated_locationList_codec = FieldCodec.ForMessage<PlayerLocation>(74U, PlayerLocation.Parser);

		// Token: 0x04009B86 RID: 39814
		private readonly RepeatedField<PlayerLocation> locationList_ = new RepeatedField<PlayerLocation>();
	}
}
