using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000582 RID: 1410
	public sealed class FlagChallengeLevelInfo : IMessage<FlagChallengeLevelInfo>, IMessage, IEquatable<FlagChallengeLevelInfo>, IDeepCloneable<FlagChallengeLevelInfo>, IBufferMessage
	{
		// Token: 0x0600831F RID: 33567 RVA: 0x0013C2D9 File Offset: 0x0013A4D9
		[NullableContext(1)]
		public static FlagChallengeLevelInfo Create()
		{
			return new FlagChallengeLevelInfo();
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0013C2E0 File Offset: 0x0013A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagChallengeLevelInfo> Parser
		{
			get
			{
				return FlagChallengeLevelInfo._parser;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06008321 RID: 33569 RVA: 0x0013C2E7 File Offset: 0x0013A4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x0013C2EA File Offset: 0x0013A4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeLevelInfo.Descriptor;
			}
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x0013C2F1 File Offset: 0x0013A4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo()
		{
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x0013C2F9 File Offset: 0x0013A4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo(FlagChallengeLevelInfo other) : this()
		{
			this.id_ = other.id_;
			this.unlockTime_ = other.unlockTime_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x0013C336 File Offset: 0x0013A536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo Clone()
		{
			return new FlagChallengeLevelInfo(this);
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06008326 RID: 33574 RVA: 0x0013C33E File Offset: 0x0013A53E
		// (set) Token: 0x06008327 RID: 33575 RVA: 0x0013C346 File Offset: 0x0013A546
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

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06008328 RID: 33576 RVA: 0x0013C34F File Offset: 0x0013A54F
		// (set) Token: 0x06008329 RID: 33577 RVA: 0x0013C357 File Offset: 0x0013A557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x0600832A RID: 33578 RVA: 0x0013C360 File Offset: 0x0013A560
		// (set) Token: 0x0600832B RID: 33579 RVA: 0x0013C368 File Offset: 0x0013A568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x0013C371 File Offset: 0x0013A571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeLevelInfo);
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x0013C380 File Offset: 0x0013A580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x0013C3DC File Offset: 0x0013A5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0013C44D File Offset: 0x0013A64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0013C45A File Offset: 0x0013A65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x0013C464 File Offset: 0x0013A664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0013C4D8 File Offset: 0x0013A6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x0013C548 File Offset: 0x0013A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0013C5AC File Offset: 0x0013A7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0013C5B8 File Offset: 0x0013A7B8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = input.ReadInt32();
						}
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041B7 RID: 16823
		private static readonly MessageParser<FlagChallengeLevelInfo> _parser = new MessageParser<FlagChallengeLevelInfo>(() => new FlagChallengeLevelInfo());

		// Token: 0x040041B8 RID: 16824
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041B9 RID: 16825
		public const int IdFieldNumber = 1;

		// Token: 0x040041BA RID: 16826
		private int id_;

		// Token: 0x040041BB RID: 16827
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x040041BC RID: 16828
		private long unlockTime_;

		// Token: 0x040041BD RID: 16829
		public const int StateFieldNumber = 3;

		// Token: 0x040041BE RID: 16830
		private int state_;
	}
}
