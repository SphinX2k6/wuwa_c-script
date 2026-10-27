using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBC RID: 3260
	[NetMessage(EMessageId.PhantomBattleSlotInsteadResponse)]
	public sealed class PhantomBattleSlotInsteadResponse : IMessage<PhantomBattleSlotInsteadResponse>, IMessage, IEquatable<PhantomBattleSlotInsteadResponse>, IDeepCloneable<PhantomBattleSlotInsteadResponse>, IBufferMessage
	{
		// Token: 0x06011A89 RID: 72329 RVA: 0x002960CC File Offset: 0x002942CC
		[NullableContext(1)]
		public static PhantomBattleSlotInsteadResponse Create()
		{
			return new PhantomBattleSlotInsteadResponse();
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x06011A8A RID: 72330 RVA: 0x002960D3 File Offset: 0x002942D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x06011A8B RID: 72331 RVA: 0x002960D6 File Offset: 0x002942D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotInsteadResponse.Descriptor;
			}
		}

		// Token: 0x06011A8C RID: 72332 RVA: 0x002960DD File Offset: 0x002942DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse()
		{
		}

		// Token: 0x06011A8D RID: 72333 RVA: 0x002960E5 File Offset: 0x002942E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse(PhantomBattleSlotInsteadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.startSlotIndex_ = other.startSlotIndex_;
			this.targetSlotIndex_ = other.targetSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A8E RID: 72334 RVA: 0x00296122 File Offset: 0x00294322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse Clone()
		{
			return new PhantomBattleSlotInsteadResponse(this);
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x06011A8F RID: 72335 RVA: 0x0029612A File Offset: 0x0029432A
		// (set) Token: 0x06011A90 RID: 72336 RVA: 0x00296132 File Offset: 0x00294332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x06011A91 RID: 72337 RVA: 0x0029613B File Offset: 0x0029433B
		// (set) Token: 0x06011A92 RID: 72338 RVA: 0x00296143 File Offset: 0x00294343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartSlotIndex
		{
			get
			{
				return this.startSlotIndex_;
			}
			set
			{
				this.startSlotIndex_ = value;
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x06011A93 RID: 72339 RVA: 0x0029614C File Offset: 0x0029434C
		// (set) Token: 0x06011A94 RID: 72340 RVA: 0x00296154 File Offset: 0x00294354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetSlotIndex
		{
			get
			{
				return this.targetSlotIndex_;
			}
			set
			{
				this.targetSlotIndex_ = value;
			}
		}

		// Token: 0x06011A95 RID: 72341 RVA: 0x0029615D File Offset: 0x0029435D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotInsteadResponse);
		}

		// Token: 0x06011A96 RID: 72342 RVA: 0x0029616C File Offset: 0x0029436C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotInsteadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.StartSlotIndex == other.StartSlotIndex && this.TargetSlotIndex == other.TargetSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A97 RID: 72343 RVA: 0x002961C8 File Offset: 0x002943C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.StartSlotIndex != 0)
			{
				num ^= this.StartSlotIndex.GetHashCode();
			}
			if (this.TargetSlotIndex != 0)
			{
				num ^= this.TargetSlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A98 RID: 72344 RVA: 0x0029623F File Offset: 0x0029443F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A99 RID: 72345 RVA: 0x0029624C File Offset: 0x0029444C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A9A RID: 72346 RVA: 0x00296258 File Offset: 0x00294458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartSlotIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartSlotIndex);
			}
			if (this.TargetSlotIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetSlotIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A9B RID: 72347 RVA: 0x002962D0 File Offset: 0x002944D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.StartSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartSlotIndex);
			}
			if (this.TargetSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetSlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A9C RID: 72348 RVA: 0x00296340 File Offset: 0x00294540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSlotInsteadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.StartSlotIndex != 0)
			{
				this.StartSlotIndex = other.StartSlotIndex;
			}
			if (other.TargetSlotIndex != 0)
			{
				this.TargetSlotIndex = other.TargetSlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A9D RID: 72349 RVA: 0x002963A4 File Offset: 0x002945A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A9E RID: 72350 RVA: 0x002963B0 File Offset: 0x002945B0
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
					if (num != 24U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.TargetSlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.StartSlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F2E RID: 28462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F2F RID: 28463
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006F30 RID: 28464
		private ErrorCode errorCode_;

		// Token: 0x04006F31 RID: 28465
		public const int StartSlotIndexFieldNumber = 2;

		// Token: 0x04006F32 RID: 28466
		private int startSlotIndex_;

		// Token: 0x04006F33 RID: 28467
		public const int TargetSlotIndexFieldNumber = 3;

		// Token: 0x04006F34 RID: 28468
		private int targetSlotIndex_;
	}
}
