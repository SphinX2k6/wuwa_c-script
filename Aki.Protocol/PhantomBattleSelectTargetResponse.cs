using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB4 RID: 3252
	[NetMessage(EMessageId.PhantomBattleSelectTargetResponse)]
	public sealed class PhantomBattleSelectTargetResponse : IMessage<PhantomBattleSelectTargetResponse>, IMessage, IEquatable<PhantomBattleSelectTargetResponse>, IDeepCloneable<PhantomBattleSelectTargetResponse>, IBufferMessage
	{
		// Token: 0x060119D6 RID: 72150 RVA: 0x00294529 File Offset: 0x00292729
		[NullableContext(1)]
		public static PhantomBattleSelectTargetResponse Create()
		{
			return new PhantomBattleSelectTargetResponse();
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x060119D7 RID: 72151 RVA: 0x00294530 File Offset: 0x00292730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x060119D8 RID: 72152 RVA: 0x00294533 File Offset: 0x00292733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetResponse.Descriptor;
			}
		}

		// Token: 0x060119D9 RID: 72153 RVA: 0x0029453A File Offset: 0x0029273A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse()
		{
		}

		// Token: 0x060119DA RID: 72154 RVA: 0x00294542 File Offset: 0x00292742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse(PhantomBattleSelectTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119DB RID: 72155 RVA: 0x00294567 File Offset: 0x00292767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse Clone()
		{
			return new PhantomBattleSelectTargetResponse(this);
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x060119DC RID: 72156 RVA: 0x0029456F File Offset: 0x0029276F
		// (set) Token: 0x060119DD RID: 72157 RVA: 0x00294577 File Offset: 0x00292777
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

		// Token: 0x060119DE RID: 72158 RVA: 0x00294580 File Offset: 0x00292780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetResponse);
		}

		// Token: 0x060119DF RID: 72159 RVA: 0x0029458E File Offset: 0x0029278E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119E0 RID: 72160 RVA: 0x002945BC File Offset: 0x002927BC
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

		// Token: 0x060119E1 RID: 72161 RVA: 0x00294601 File Offset: 0x00292801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119E2 RID: 72162 RVA: 0x0029460E File Offset: 0x0029280E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119E3 RID: 72163 RVA: 0x00294617 File Offset: 0x00292817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119E4 RID: 72164 RVA: 0x0029464C File Offset: 0x0029284C
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

		// Token: 0x060119E5 RID: 72165 RVA: 0x0029468A File Offset: 0x0029288A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectTargetResponse other)
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

		// Token: 0x060119E6 RID: 72166 RVA: 0x002946BB File Offset: 0x002928BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119E7 RID: 72167 RVA: 0x002946C4 File Offset: 0x002928C4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006EEF RID: 28399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EF0 RID: 28400
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006EF1 RID: 28401
		private ErrorCode errorCode_;
	}
}
