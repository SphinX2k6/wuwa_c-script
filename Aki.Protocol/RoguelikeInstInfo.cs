using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F91 RID: 3985
	public sealed class RoguelikeInstInfo : IMessage<RoguelikeInstInfo>, IMessage, IEquatable<RoguelikeInstInfo>, IDeepCloneable<RoguelikeInstInfo>, IBufferMessage
	{
		// Token: 0x06015570 RID: 87408 RVA: 0x00319875 File Offset: 0x00317A75
		[NullableContext(1)]
		public static RoguelikeInstInfo Create()
		{
			return new RoguelikeInstInfo();
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x06015571 RID: 87409 RVA: 0x0031987C File Offset: 0x00317A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x06015572 RID: 87410 RVA: 0x0031987F File Offset: 0x00317A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeInstInfo.Descriptor;
			}
		}

		// Token: 0x06015573 RID: 87411 RVA: 0x00319886 File Offset: 0x00317A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo()
		{
		}

		// Token: 0x06015574 RID: 87412 RVA: 0x003198B0 File Offset: 0x00317AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo(RoguelikeInstInfo other) : this()
		{
			this.roleEntry_ = ((other.roleEntry_ != null) ? other.roleEntry_.Clone() : null);
			this.phantomEntry_ = ((other.phantomEntry_ != null) ? other.phantomEntry_.Clone() : null);
			this.buffEntryList_ = other.buffEntryList_.Clone();
			this.elementDict_ = other.elementDict_.Clone();
			this.miraclecreationList_ = other.miraclecreationList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015575 RID: 87413 RVA: 0x0031993F File Offset: 0x00317B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo Clone()
		{
			return new RoguelikeInstInfo(this);
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x06015576 RID: 87414 RVA: 0x00319947 File Offset: 0x00317B47
		// (set) Token: 0x06015577 RID: 87415 RVA: 0x0031994F File Offset: 0x00317B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry RoleEntry
		{
			get
			{
				return this.roleEntry_;
			}
			set
			{
				this.roleEntry_ = value;
			}
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x06015578 RID: 87416 RVA: 0x00319958 File Offset: 0x00317B58
		// (set) Token: 0x06015579 RID: 87417 RVA: 0x00319960 File Offset: 0x00317B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry PhantomEntry
		{
			get
			{
				return this.phantomEntry_;
			}
			set
			{
				this.phantomEntry_ = value;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x0601557A RID: 87418 RVA: 0x00319969 File Offset: 0x00317B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.buffEntryList_;
			}
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x0601557B RID: 87419 RVA: 0x00319971 File Offset: 0x00317B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x0601557C RID: 87420 RVA: 0x00319979 File Offset: 0x00317B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> MiraclecreationList
		{
			get
			{
				return this.miraclecreationList_;
			}
		}

		// Token: 0x0601557D RID: 87421 RVA: 0x00319981 File Offset: 0x00317B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeInstInfo);
		}

		// Token: 0x0601557E RID: 87422 RVA: 0x00319990 File Offset: 0x00317B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeInstInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.buffEntryList_.Equals(other.buffEntryList_) && this.ElementDict.Equals(other.ElementDict) && this.miraclecreationList_.Equals(other.miraclecreationList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601557F RID: 87423 RVA: 0x00319A24 File Offset: 0x00317C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleEntry_ != null)
			{
				num ^= this.RoleEntry.GetHashCode();
			}
			if (this.phantomEntry_ != null)
			{
				num ^= this.PhantomEntry.GetHashCode();
			}
			num ^= this.buffEntryList_.GetHashCode();
			num ^= this.ElementDict.GetHashCode();
			num ^= this.miraclecreationList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015580 RID: 87424 RVA: 0x00319AA0 File Offset: 0x00317CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015581 RID: 87425 RVA: 0x00319AAD File Offset: 0x00317CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015582 RID: 87426 RVA: 0x00319AB8 File Offset: 0x00317CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomEntry);
			}
			this.buffEntryList_.WriteTo(ref output, RoguelikeInstInfo._repeated_buffEntryList_codec);
			this.elementDict_.WriteTo(ref output, RoguelikeInstInfo._map_elementDict_codec);
			this.miraclecreationList_.WriteTo(ref output, RoguelikeInstInfo._repeated_miraclecreationList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015583 RID: 87427 RVA: 0x00319B44 File Offset: 0x00317D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomEntry);
			}
			num += this.buffEntryList_.CalculateSize(RoguelikeInstInfo._repeated_buffEntryList_codec);
			num += this.elementDict_.CalculateSize(RoguelikeInstInfo._map_elementDict_codec);
			num += this.miraclecreationList_.CalculateSize(RoguelikeInstInfo._repeated_miraclecreationList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015584 RID: 87428 RVA: 0x00319BD4 File Offset: 0x00317DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeInstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleEntry_ != null)
			{
				if (this.roleEntry_ == null)
				{
					this.RoleEntry = new RogueGainEntry();
				}
				this.RoleEntry.MergeFrom(other.RoleEntry);
			}
			if (other.phantomEntry_ != null)
			{
				if (this.phantomEntry_ == null)
				{
					this.PhantomEntry = new RogueGainEntry();
				}
				this.PhantomEntry.MergeFrom(other.PhantomEntry);
			}
			this.buffEntryList_.Add(other.buffEntryList_);
			this.elementDict_.MergeFrom(other.elementDict_);
			this.miraclecreationList_.Add(other.miraclecreationList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015585 RID: 87429 RVA: 0x00319C87 File Offset: 0x00317E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015586 RID: 87430 RVA: 0x00319C90 File Offset: 0x00317E90
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.roleEntry_ == null)
						{
							this.RoleEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RoleEntry);
						continue;
					}
					if (num == 18U)
					{
						if (this.phantomEntry_ == null)
						{
							this.PhantomEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.PhantomEntry);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.buffEntryList_.AddEntriesFrom(ref input, RoguelikeInstInfo._repeated_buffEntryList_codec);
						continue;
					}
					if (num == 34U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeInstInfo._map_elementDict_codec);
						continue;
					}
					if (num == 42U)
					{
						this.miraclecreationList_.AddEntriesFrom(ref input, RoguelikeInstInfo._repeated_miraclecreationList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080E0 RID: 32992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080E1 RID: 32993
		public const int RoleEntryFieldNumber = 1;

		// Token: 0x040080E2 RID: 32994
		private RogueGainEntry roleEntry_;

		// Token: 0x040080E3 RID: 32995
		public const int PhantomEntryFieldNumber = 2;

		// Token: 0x040080E4 RID: 32996
		private RogueGainEntry phantomEntry_;

		// Token: 0x040080E5 RID: 32997
		public const int BuffEntryListFieldNumber = 3;

		// Token: 0x040080E6 RID: 32998
		private static readonly FieldCodec<RogueGainEntry> _repeated_buffEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(26U, RogueGainEntry.Parser);

		// Token: 0x040080E7 RID: 32999
		private readonly RepeatedField<RogueGainEntry> buffEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080E8 RID: 33000
		public const int ElementDictFieldNumber = 4;

		// Token: 0x040080E9 RID: 33001
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040080EA RID: 33002
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x040080EB RID: 33003
		public const int MiraclecreationListFieldNumber = 5;

		// Token: 0x040080EC RID: 33004
		private static readonly FieldCodec<RogueGainEntry> _repeated_miraclecreationList_codec = FieldCodec.ForMessage<RogueGainEntry>(42U, RogueGainEntry.Parser);

		// Token: 0x040080ED RID: 33005
		private readonly RepeatedField<RogueGainEntry> miraclecreationList_ = new RepeatedField<RogueGainEntry>();
	}
}
