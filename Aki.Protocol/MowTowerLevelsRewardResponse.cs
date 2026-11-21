using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABE RID: 2750
	[NetMessage(EMessageId.MowTowerLevelsRewardResponse)]
	public sealed class MowTowerLevelsRewardResponse : IMessage<MowTowerLevelsRewardResponse>, IMessage, IEquatable<MowTowerLevelsRewardResponse>, IDeepCloneable<MowTowerLevelsRewardResponse>, IBufferMessage
	{
		// Token: 0x0600EFCD RID: 61389 RVA: 0x00231141 File Offset: 0x0022F341
		[NullableContext(1)]
		public static MowTowerLevelsRewardResponse Create()
		{
			return new MowTowerLevelsRewardResponse();
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x00231148 File Offset: 0x0022F348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600EFCF RID: 61391 RVA: 0x0023114B File Offset: 0x0022F34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600EFD0 RID: 61392 RVA: 0x00231152 File Offset: 0x0022F352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse()
		{
		}

		// Token: 0x0600EFD1 RID: 61393 RVA: 0x0023115A File Offset: 0x0022F35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse(MowTowerLevelsRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFD2 RID: 61394 RVA: 0x0023117F File Offset: 0x0022F37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse Clone()
		{
			return new MowTowerLevelsRewardResponse(this);
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600EFD3 RID: 61395 RVA: 0x00231187 File Offset: 0x0022F387
		// (set) Token: 0x0600EFD4 RID: 61396 RVA: 0x0023118F File Offset: 0x0022F38F
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

		// Token: 0x0600EFD5 RID: 61397 RVA: 0x00231198 File Offset: 0x0022F398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsRewardResponse);
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x002311A6 File Offset: 0x0022F3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFD7 RID: 61399 RVA: 0x002311D4 File Offset: 0x0022F3D4
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

		// Token: 0x0600EFD8 RID: 61400 RVA: 0x00231219 File Offset: 0x0022F419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFD9 RID: 61401 RVA: 0x00231226 File Offset: 0x0022F426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFDA RID: 61402 RVA: 0x0023122F File Offset: 0x0022F42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x00231264 File Offset: 0x0022F464
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

		// Token: 0x0600EFDC RID: 61404 RVA: 0x002312A2 File Offset: 0x0022F4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsRewardResponse other)
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

		// Token: 0x0600EFDD RID: 61405 RVA: 0x002312D3 File Offset: 0x0022F4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x002312DC File Offset: 0x0022F4DC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400616B RID: 24939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400616C RID: 24940
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400616D RID: 24941
		private ErrorCode errorCode_;
	}
}
