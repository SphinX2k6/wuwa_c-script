using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C46 RID: 3142
	[NetMessage(EMessageId.PhantomBattleCardPosChangeNotify)]
	public sealed class PhantomBattleCardPosChangeNotify : IMessage<PhantomBattleCardPosChangeNotify>, IMessage, IEquatable<PhantomBattleCardPosChangeNotify>, IDeepCloneable<PhantomBattleCardPosChangeNotify>, IBufferMessage
	{
		// Token: 0x060110F8 RID: 69880 RVA: 0x0028005F File Offset: 0x0027E25F
		[NullableContext(1)]
		public static PhantomBattleCardPosChangeNotify Create()
		{
			return new PhantomBattleCardPosChangeNotify();
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x060110F9 RID: 69881 RVA: 0x00280066 File Offset: 0x0027E266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x060110FA RID: 69882 RVA: 0x00280069 File Offset: 0x0027E269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardPosChangeNotify.Descriptor;
			}
		}

		// Token: 0x060110FB RID: 69883 RVA: 0x00280070 File Offset: 0x0027E270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify()
		{
		}

		// Token: 0x060110FC RID: 69884 RVA: 0x00280083 File Offset: 0x0027E283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify(PhantomBattleCardPosChangeNotify other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.changeInfo_ = other.changeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110FD RID: 69885 RVA: 0x002800B9 File Offset: 0x0027E2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify Clone()
		{
			return new PhantomBattleCardPosChangeNotify(this);
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x060110FE RID: 69886 RVA: 0x002800C1 File Offset: 0x0027E2C1
		// (set) Token: 0x060110FF RID: 69887 RVA: 0x002800C9 File Offset: 0x0027E2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x06011100 RID: 69888 RVA: 0x002800D2 File Offset: 0x0027E2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardPosChangeInfo> ChangeInfo
		{
			get
			{
				return this.changeInfo_;
			}
		}

		// Token: 0x06011101 RID: 69889 RVA: 0x002800DA File Offset: 0x0027E2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardPosChangeNotify);
		}

		// Token: 0x06011102 RID: 69890 RVA: 0x002800E8 File Offset: 0x0027E2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardPosChangeNotify other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.changeInfo_.Equals(other.changeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011103 RID: 69891 RVA: 0x00280138 File Offset: 0x0027E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			num ^= this.changeInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011104 RID: 69892 RVA: 0x00280185 File Offset: 0x0027E385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011105 RID: 69893 RVA: 0x00280192 File Offset: 0x0027E392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011106 RID: 69894 RVA: 0x0028019C File Offset: 0x0027E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeInfo_.WriteTo(ref output, PhantomBattleCardPosChangeNotify._repeated_changeInfo_codec);
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GamerIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011107 RID: 69895 RVA: 0x002801EC File Offset: 0x0027E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			num += this.changeInfo_.CalculateSize(PhantomBattleCardPosChangeNotify._repeated_changeInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011108 RID: 69896 RVA: 0x00280240 File Offset: 0x0027E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardPosChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			this.changeInfo_.Add(other.changeInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011109 RID: 69897 RVA: 0x0028028D File Offset: 0x0027E48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601110A RID: 69898 RVA: 0x00280298 File Offset: 0x0027E498
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
				if (num != 10U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GamerIndex = input.ReadInt32();
					}
				}
				else
				{
					this.changeInfo_.AddEntriesFrom(ref input, PhantomBattleCardPosChangeNotify._repeated_changeInfo_codec);
				}
			}
		}

		// Token: 0x04006C7F RID: 27775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C80 RID: 27776
		public const int GamerIndexFieldNumber = 8;

		// Token: 0x04006C81 RID: 27777
		private int gamerIndex_;

		// Token: 0x04006C82 RID: 27778
		public const int ChangeInfoFieldNumber = 1;

		// Token: 0x04006C83 RID: 27779
		private static readonly FieldCodec<PhantomBattleCardPosChangeInfo> _repeated_changeInfo_codec = FieldCodec.ForMessage<PhantomBattleCardPosChangeInfo>(10U, PhantomBattleCardPosChangeInfo.Parser);

		// Token: 0x04006C84 RID: 27780
		private readonly RepeatedField<PhantomBattleCardPosChangeInfo> changeInfo_ = new RepeatedField<PhantomBattleCardPosChangeInfo>();
	}
}
