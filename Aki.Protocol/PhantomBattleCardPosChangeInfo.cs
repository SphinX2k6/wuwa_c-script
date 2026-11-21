using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C45 RID: 3141
	public sealed class PhantomBattleCardPosChangeInfo : IMessage<PhantomBattleCardPosChangeInfo>, IMessage, IEquatable<PhantomBattleCardPosChangeInfo>, IDeepCloneable<PhantomBattleCardPosChangeInfo>, IBufferMessage
	{
		// Token: 0x060110E2 RID: 69858 RVA: 0x0027FDA9 File Offset: 0x0027DFA9
		[NullableContext(1)]
		public static PhantomBattleCardPosChangeInfo Create()
		{
			return new PhantomBattleCardPosChangeInfo();
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x060110E3 RID: 69859 RVA: 0x0027FDB0 File Offset: 0x0027DFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardPosChangeInfo> Parser
		{
			get
			{
				return PhantomBattleCardPosChangeInfo._parser;
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x060110E4 RID: 69860 RVA: 0x0027FDB7 File Offset: 0x0027DFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x060110E5 RID: 69861 RVA: 0x0027FDBA File Offset: 0x0027DFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardPosChangeInfo.Descriptor;
			}
		}

		// Token: 0x060110E6 RID: 69862 RVA: 0x0027FDC1 File Offset: 0x0027DFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo()
		{
		}

		// Token: 0x060110E7 RID: 69863 RVA: 0x0027FDC9 File Offset: 0x0027DFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo(PhantomBattleCardPosChangeInfo other) : this()
		{
			this.fighterUid_ = other.fighterUid_;
			this.afterPos_ = other.afterPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110E8 RID: 69864 RVA: 0x0027FDFA File Offset: 0x0027DFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo Clone()
		{
			return new PhantomBattleCardPosChangeInfo(this);
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x060110E9 RID: 69865 RVA: 0x0027FE02 File Offset: 0x0027E002
		// (set) Token: 0x060110EA RID: 69866 RVA: 0x0027FE0A File Offset: 0x0027E00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FighterUid
		{
			get
			{
				return this.fighterUid_;
			}
			set
			{
				this.fighterUid_ = value;
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x060110EB RID: 69867 RVA: 0x0027FE13 File Offset: 0x0027E013
		// (set) Token: 0x060110EC RID: 69868 RVA: 0x0027FE1B File Offset: 0x0027E01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterPos
		{
			get
			{
				return this.afterPos_;
			}
			set
			{
				this.afterPos_ = value;
			}
		}

		// Token: 0x060110ED RID: 69869 RVA: 0x0027FE24 File Offset: 0x0027E024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardPosChangeInfo);
		}

		// Token: 0x060110EE RID: 69870 RVA: 0x0027FE32 File Offset: 0x0027E032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardPosChangeInfo other)
		{
			return other != null && (other == this || (this.FighterUid == other.FighterUid && this.AfterPos == other.AfterPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110EF RID: 69871 RVA: 0x0027FE70 File Offset: 0x0027E070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FighterUid != 0)
			{
				num ^= this.FighterUid.GetHashCode();
			}
			if (this.AfterPos != 0)
			{
				num ^= this.AfterPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110F0 RID: 69872 RVA: 0x0027FEC8 File Offset: 0x0027E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110F1 RID: 69873 RVA: 0x0027FED5 File Offset: 0x0027E0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110F2 RID: 69874 RVA: 0x0027FEE0 File Offset: 0x0027E0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FighterUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FighterUid);
			}
			if (this.AfterPos != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AfterPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110F3 RID: 69875 RVA: 0x0027FF38 File Offset: 0x0027E138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FighterUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FighterUid);
			}
			if (this.AfterPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110F4 RID: 69876 RVA: 0x0027FF90 File Offset: 0x0027E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardPosChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FighterUid != 0)
			{
				this.FighterUid = other.FighterUid;
			}
			if (other.AfterPos != 0)
			{
				this.AfterPos = other.AfterPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110F5 RID: 69877 RVA: 0x0027FFE0 File Offset: 0x0027E1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110F6 RID: 69878 RVA: 0x0027FFEC File Offset: 0x0027E1EC
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AfterPos = input.ReadInt32();
					}
				}
				else
				{
					this.FighterUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C79 RID: 27769
		private static readonly MessageParser<PhantomBattleCardPosChangeInfo> _parser = new MessageParser<PhantomBattleCardPosChangeInfo>(() => new PhantomBattleCardPosChangeInfo());

		// Token: 0x04006C7A RID: 27770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C7B RID: 27771
		public const int FighterUidFieldNumber = 1;

		// Token: 0x04006C7C RID: 27772
		private int fighterUid_;

		// Token: 0x04006C7D RID: 27773
		public const int AfterPosFieldNumber = 3;

		// Token: 0x04006C7E RID: 27774
		private int afterPos_;
	}
}
