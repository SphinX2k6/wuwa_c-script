using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C56 RID: 3158
	[NetMessage(EMessageId.PhantomBattleCardPosChangeNotify)]
	public sealed class PhantomBattleCardPosChangeNotify : IMessage<PhantomBattleCardPosChangeNotify>, IMessage, IEquatable<PhantomBattleCardPosChangeNotify>, IDeepCloneable<PhantomBattleCardPosChangeNotify>, IBufferMessage
	{
		// Token: 0x060111F8 RID: 70136 RVA: 0x00281DCF File Offset: 0x0027FFCF
		[NullableContext(1)]
		public static PhantomBattleCardPosChangeNotify Create()
		{
			return new PhantomBattleCardPosChangeNotify();
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x060111F9 RID: 70137 RVA: 0x00281DD6 File Offset: 0x0027FFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x060111FA RID: 70138 RVA: 0x00281DD9 File Offset: 0x0027FFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardPosChangeNotify.Descriptor;
			}
		}

		// Token: 0x060111FB RID: 70139 RVA: 0x00281DE0 File Offset: 0x0027FFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify()
		{
		}

		// Token: 0x060111FC RID: 70140 RVA: 0x00281DF3 File Offset: 0x0027FFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify(PhantomBattleCardPosChangeNotify other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.changeInfo_ = other.changeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111FD RID: 70141 RVA: 0x00281E29 File Offset: 0x00280029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeNotify Clone()
		{
			return new PhantomBattleCardPosChangeNotify(this);
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x060111FE RID: 70142 RVA: 0x00281E31 File Offset: 0x00280031
		// (set) Token: 0x060111FF RID: 70143 RVA: 0x00281E39 File Offset: 0x00280039
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

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x06011200 RID: 70144 RVA: 0x00281E42 File Offset: 0x00280042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardPosChangeInfo> ChangeInfo
		{
			get
			{
				return this.changeInfo_;
			}
		}

		// Token: 0x06011201 RID: 70145 RVA: 0x00281E4A File Offset: 0x0028004A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardPosChangeNotify);
		}

		// Token: 0x06011202 RID: 70146 RVA: 0x00281E58 File Offset: 0x00280058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardPosChangeNotify other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.changeInfo_.Equals(other.changeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011203 RID: 70147 RVA: 0x00281EA8 File Offset: 0x002800A8
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

		// Token: 0x06011204 RID: 70148 RVA: 0x00281EF5 File Offset: 0x002800F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011205 RID: 70149 RVA: 0x00281F02 File Offset: 0x00280102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011206 RID: 70150 RVA: 0x00281F0C File Offset: 0x0028010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeInfo_.WriteTo(ref output, PhantomBattleCardPosChangeNotify._repeated_changeInfo_codec);
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GamerIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011207 RID: 70151 RVA: 0x00281F5C File Offset: 0x0028015C
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

		// Token: 0x06011208 RID: 70152 RVA: 0x00281FB0 File Offset: 0x002801B0
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

		// Token: 0x06011209 RID: 70153 RVA: 0x00281FFD File Offset: 0x002801FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601120A RID: 70154 RVA: 0x00282008 File Offset: 0x00280208
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
				if (num != 58U)
				{
					if (num != 72U)
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

		// Token: 0x04006C6B RID: 27755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C6C RID: 27756
		public const int GamerIndexFieldNumber = 9;

		// Token: 0x04006C6D RID: 27757
		private int gamerIndex_;

		// Token: 0x04006C6E RID: 27758
		public const int ChangeInfoFieldNumber = 7;

		// Token: 0x04006C6F RID: 27759
		private static readonly FieldCodec<PhantomBattleCardPosChangeInfo> _repeated_changeInfo_codec = FieldCodec.ForMessage<PhantomBattleCardPosChangeInfo>(58U, PhantomBattleCardPosChangeInfo.Parser);

		// Token: 0x04006C70 RID: 27760
		private readonly RepeatedField<PhantomBattleCardPosChangeInfo> changeInfo_ = new RepeatedField<PhantomBattleCardPosChangeInfo>();
	}
}
