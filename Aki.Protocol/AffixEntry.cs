using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D7 RID: 215
	public sealed class AffixEntry : IMessage<AffixEntry>, IMessage, IEquatable<AffixEntry>, IDeepCloneable<AffixEntry>, IBufferMessage
	{
		// Token: 0x060020B9 RID: 8377 RVA: 0x000583A8 File Offset: 0x000565A8
		[NullableContext(1)]
		public static AffixEntry Create()
		{
			return new AffixEntry();
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000583AF File Offset: 0x000565AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AffixEntry> Parser
		{
			get
			{
				return AffixEntry._parser;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000583B6 File Offset: 0x000565B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x000583B9 File Offset: 0x000565B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AffixEntry.Descriptor;
			}
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000583C0 File Offset: 0x000565C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry()
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000583D4 File Offset: 0x000565D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry(AffixEntry other) : this()
		{
			this.id_ = other.id_;
			this.isUnlock_ = other.isUnlock_;
			this.elementDict_ = other.elementDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00058421 File Offset: 0x00056621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AffixEntry Clone()
		{
			return new AffixEntry(this);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00058429 File Offset: 0x00056629
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00058431 File Offset: 0x00056631
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0005843A File Offset: 0x0005663A
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00058442 File Offset: 0x00056642
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0005844B File Offset: 0x0005664B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00058453 File Offset: 0x00056653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AffixEntry);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00058464 File Offset: 0x00056664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AffixEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsUnlock == other.IsUnlock && this.ElementDict.Equals(other.ElementDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000584C4 File Offset: 0x000566C4
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

		// Token: 0x060020C8 RID: 8392 RVA: 0x0005852A File Offset: 0x0005672A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00058537 File Offset: 0x00056737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00058540 File Offset: 0x00056740
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

		// Token: 0x060020CB RID: 8395 RVA: 0x000585AC File Offset: 0x000567AC
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

		// Token: 0x060020CC RID: 8396 RVA: 0x0005860C File Offset: 0x0005680C
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

		// Token: 0x060020CD RID: 8397 RVA: 0x0005866D File Offset: 0x0005686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00058678 File Offset: 0x00056878
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

		// Token: 0x04002458 RID: 9304
		private static readonly MessageParser<AffixEntry> _parser = new MessageParser<AffixEntry>(() => new AffixEntry());

		// Token: 0x04002459 RID: 9305
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400245A RID: 9306
		public const int IdFieldNumber = 1;

		// Token: 0x0400245B RID: 9307
		private int id_;

		// Token: 0x0400245C RID: 9308
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x0400245D RID: 9309
		private bool isUnlock_;

		// Token: 0x0400245E RID: 9310
		public const int ElementDictFieldNumber = 3;

		// Token: 0x0400245F RID: 9311
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04002460 RID: 9312
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();
	}
}
