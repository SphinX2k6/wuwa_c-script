using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D6 RID: 214
	public sealed class AffixEntry : IMessage<AffixEntry>, IMessage, IEquatable<AffixEntry>, IDeepCloneable<AffixEntry>, IBufferMessage
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x000576F4 File Offset: 0x000558F4
		[NullableContext(1)]
		public static AffixEntry Create()
		{
			return new AffixEntry();
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x000576FB File Offset: 0x000558FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AffixEntry> Parser
		{
			get
			{
				return AffixEntry._parser;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00057702 File Offset: 0x00055902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00057705 File Offset: 0x00055905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AffixEntry.Descriptor;
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0005770C File Offset: 0x0005590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry()
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00057720 File Offset: 0x00055920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry(AffixEntry other) : this()
		{
			this.id_ = other.id_;
			this.isUnlock_ = other.isUnlock_;
			this.elementDict_ = other.elementDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0005776D File Offset: 0x0005596D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry Clone()
		{
			return new AffixEntry(this);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00057775 File Offset: 0x00055975
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0005777D File Offset: 0x0005597D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00057786 File Offset: 0x00055986
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0005778E File Offset: 0x0005598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x00057797 File Offset: 0x00055997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0005779F File Offset: 0x0005599F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AffixEntry);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000577B0 File Offset: 0x000559B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AffixEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsUnlock == other.IsUnlock && this.ElementDict.Equals(other.ElementDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00057810 File Offset: 0x00055A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			num ^= this.ElementDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00057876 File Offset: 0x00055A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00057883 File Offset: 0x00055A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0005788C File Offset: 0x00055A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			this.elementDict_.WriteTo(ref output, AffixEntry._map_elementDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000578F8 File Offset: 0x00055AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			num += this.elementDict_.CalculateSize(AffixEntry._map_elementDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00057958 File Offset: 0x00055B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AffixEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this.elementDict_.MergeFrom(other.elementDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000579B9 File Offset: 0x00055BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x000579C4 File Offset: 0x00055BC4
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.elementDict_.AddEntriesFrom(ref input, AffixEntry._map_elementDict_codec);
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023F5 RID: 9205
		private static readonly MessageParser<AffixEntry> _parser = new MessageParser<AffixEntry>(() => new AffixEntry());

		// Token: 0x040023F6 RID: 9206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F7 RID: 9207
		public const int IdFieldNumber = 1;

		// Token: 0x040023F8 RID: 9208
		private int id_;

		// Token: 0x040023F9 RID: 9209
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040023FA RID: 9210
		private bool isUnlock_;

		// Token: 0x040023FB RID: 9211
		public const int ElementDictFieldNumber = 3;

		// Token: 0x040023FC RID: 9212
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040023FD RID: 9213
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();
	}
}
