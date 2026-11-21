using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016E RID: 366
	[NetMessage(EMessageId.BattlePassLevelUpRequest)]
	public sealed class BattlePassLevelUpRequest : IMessage<BattlePassLevelUpRequest>, IMessage, IEquatable<BattlePassLevelUpRequest>, IDeepCloneable<BattlePassLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06002D6B RID: 11627 RVA: 0x00075F55 File Offset: 0x00074155
		[NullableContext(1)]
		public static BattlePassLevelUpRequest Create()
		{
			return new BattlePassLevelUpRequest();
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x00075F5C File Offset: 0x0007415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x00075F5F File Offset: 0x0007415F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00075F66 File Offset: 0x00074166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest()
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00075F6E File Offset: 0x0007416E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest(BattlePassLevelUpRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00075F93 File Offset: 0x00074193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest Clone()
		{
			return new BattlePassLevelUpRequest(this);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00075F9B File Offset: 0x0007419B
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x00075FA3 File Offset: 0x000741A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00075FAC File Offset: 0x000741AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassLevelUpRequest);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00075FBA File Offset: 0x000741BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassLevelUpRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00075FE8 File Offset: 0x000741E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00076027 File Offset: 0x00074227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00076034 File Offset: 0x00074234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0007603D File Offset: 0x0007423D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00076070 File Offset: 0x00074270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000760AE File Offset: 0x000742AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000760DF File Offset: 0x000742DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000760E8 File Offset: 0x000742E8
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002891 RID: 10385
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002892 RID: 10386
		public const int LevelFieldNumber = 2;

		// Token: 0x04002893 RID: 10387
		private int level_;
	}
}
