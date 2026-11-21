using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C4 RID: 2500
	[NetMessage(EMessageId.MingSuHandRewardResponse)]
	public sealed class MingSuHandRewardResponse : IMessage<MingSuHandRewardResponse>, IMessage, IEquatable<MingSuHandRewardResponse>, IDeepCloneable<MingSuHandRewardResponse>, IBufferMessage
	{
		// Token: 0x0600DB9D RID: 56221 RVA: 0x00204494 File Offset: 0x00202694
		[NullableContext(1)]
		public static MingSuHandRewardResponse Create()
		{
			return new MingSuHandRewardResponse();
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600DB9E RID: 56222 RVA: 0x0020449B File Offset: 0x0020269B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600DB9F RID: 56223 RVA: 0x0020449E File Offset: 0x0020269E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuHandRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600DBA0 RID: 56224 RVA: 0x002044A5 File Offset: 0x002026A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse()
		{
		}

		// Token: 0x0600DBA1 RID: 56225 RVA: 0x002044AD File Offset: 0x002026AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse(MingSuHandRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBA2 RID: 56226 RVA: 0x002044DE File Offset: 0x002026DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse Clone()
		{
			return new MingSuHandRewardResponse(this);
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x002044E6 File Offset: 0x002026E6
		// (set) Token: 0x0600DBA4 RID: 56228 RVA: 0x002044EE File Offset: 0x002026EE
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

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x002044F7 File Offset: 0x002026F7
		// (set) Token: 0x0600DBA6 RID: 56230 RVA: 0x002044FF File Offset: 0x002026FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGains
		{
			get
			{
				return this.levelGains_;
			}
			set
			{
				this.levelGains_ = value;
			}
		}

		// Token: 0x0600DBA7 RID: 56231 RVA: 0x00204508 File Offset: 0x00202708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuHandRewardResponse);
		}

		// Token: 0x0600DBA8 RID: 56232 RVA: 0x00204516 File Offset: 0x00202716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuHandRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBA9 RID: 56233 RVA: 0x00204554 File Offset: 0x00202754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LevelGains != 0)
			{
				num ^= this.LevelGains.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBAA RID: 56234 RVA: 0x002045B2 File Offset: 0x002027B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBAB RID: 56235 RVA: 0x002045BF File Offset: 0x002027BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBAC RID: 56236 RVA: 0x002045C8 File Offset: 0x002027C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBAD RID: 56237 RVA: 0x00204624 File Offset: 0x00202824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LevelGains != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x0020467C File Offset: 0x0020287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MingSuHandRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x002046CC File Offset: 0x002028CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBB0 RID: 56240 RVA: 0x002046D8 File Offset: 0x002028D8
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelGains = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B6E RID: 23406
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B6F RID: 23407
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005B70 RID: 23408
		private ErrorCode errorCode_;

		// Token: 0x04005B71 RID: 23409
		public const int LevelGainsFieldNumber = 10;

		// Token: 0x04005B72 RID: 23410
		private int levelGains_;
	}
}
