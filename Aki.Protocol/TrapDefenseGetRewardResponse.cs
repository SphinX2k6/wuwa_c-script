using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001428 RID: 5160
	[NetMessage(EMessageId.TrapDefenseGetRewardResponse)]
	public sealed class TrapDefenseGetRewardResponse : IMessage<TrapDefenseGetRewardResponse>, IMessage, IEquatable<TrapDefenseGetRewardResponse>, IDeepCloneable<TrapDefenseGetRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B583 RID: 112003 RVA: 0x003F61C9 File Offset: 0x003F43C9
		[NullableContext(1)]
		public static TrapDefenseGetRewardResponse Create()
		{
			return new TrapDefenseGetRewardResponse();
		}

		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x0601B584 RID: 112004 RVA: 0x003F61D0 File Offset: 0x003F43D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x0601B585 RID: 112005 RVA: 0x003F61D3 File Offset: 0x003F43D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B586 RID: 112006 RVA: 0x003F61DA File Offset: 0x003F43DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse()
		{
		}

		// Token: 0x0601B587 RID: 112007 RVA: 0x003F61E2 File Offset: 0x003F43E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse(TrapDefenseGetRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B588 RID: 112008 RVA: 0x003F6207 File Offset: 0x003F4407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardResponse Clone()
		{
			return new TrapDefenseGetRewardResponse(this);
		}

		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0601B589 RID: 112009 RVA: 0x003F620F File Offset: 0x003F440F
		// (set) Token: 0x0601B58A RID: 112010 RVA: 0x003F6217 File Offset: 0x003F4417
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

		// Token: 0x0601B58B RID: 112011 RVA: 0x003F6220 File Offset: 0x003F4420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetRewardResponse);
		}

		// Token: 0x0601B58C RID: 112012 RVA: 0x003F622E File Offset: 0x003F442E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B58D RID: 112013 RVA: 0x003F625C File Offset: 0x003F445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B58E RID: 112014 RVA: 0x003F62A1 File Offset: 0x003F44A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B58F RID: 112015 RVA: 0x003F62AE File Offset: 0x003F44AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B590 RID: 112016 RVA: 0x003F62B7 File Offset: 0x003F44B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B591 RID: 112017 RVA: 0x003F62EC File Offset: 0x003F44EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B592 RID: 112018 RVA: 0x003F632A File Offset: 0x003F452A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B593 RID: 112019 RVA: 0x003F635B File Offset: 0x003F455B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B594 RID: 112020 RVA: 0x003F6364 File Offset: 0x003F4564
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DF9 RID: 40441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DFA RID: 40442
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009DFB RID: 40443
		private ErrorCode errorCode_;
	}
}
