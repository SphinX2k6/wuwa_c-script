using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016B RID: 363
	[NetMessage(EMessageId.BattlePassLevelUpRequest)]
	public sealed class BattlePassLevelUpRequest : IMessage<BattlePassLevelUpRequest>, IMessage, IEquatable<BattlePassLevelUpRequest>, IDeepCloneable<BattlePassLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06002CF4 RID: 11508 RVA: 0x00074B21 File Offset: 0x00072D21
		[NullableContext(1)]
		public static BattlePassLevelUpRequest Create()
		{
			return new BattlePassLevelUpRequest();
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x00074B28 File Offset: 0x00072D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x00074B2B File Offset: 0x00072D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00074B32 File Offset: 0x00072D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest()
		{
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00074B3A File Offset: 0x00072D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest(BattlePassLevelUpRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00074B5F File Offset: 0x00072D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpRequest Clone()
		{
			return new BattlePassLevelUpRequest(this);
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x00074B67 File Offset: 0x00072D67
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x00074B6F File Offset: 0x00072D6F
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

		// Token: 0x06002CFC RID: 11516 RVA: 0x00074B78 File Offset: 0x00072D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassLevelUpRequest);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00074B86 File Offset: 0x00072D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassLevelUpRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00074BB4 File Offset: 0x00072DB4
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

		// Token: 0x06002CFF RID: 11519 RVA: 0x00074BF3 File Offset: 0x00072DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00074C00 File Offset: 0x00072E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x00074C09 File Offset: 0x00072E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00074C3C File Offset: 0x00072E3C
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

		// Token: 0x06002D03 RID: 11523 RVA: 0x00074C7A File Offset: 0x00072E7A
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

		// Token: 0x06002D04 RID: 11524 RVA: 0x00074CAB File Offset: 0x00072EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00074CB4 File Offset: 0x00072EB4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400281D RID: 10269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400281E RID: 10270
		public const int LevelFieldNumber = 12;

		// Token: 0x0400281F RID: 10271
		private int level_;
	}
}
