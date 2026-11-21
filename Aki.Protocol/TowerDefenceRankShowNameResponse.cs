using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141F RID: 5151
	[NetMessage(EMessageId.TowerDefenceRankShowNameResponse)]
	public sealed class TowerDefenceRankShowNameResponse : IMessage<TowerDefenceRankShowNameResponse>, IMessage, IEquatable<TowerDefenceRankShowNameResponse>, IDeepCloneable<TowerDefenceRankShowNameResponse>, IBufferMessage
	{
		// Token: 0x0601B60D RID: 112141 RVA: 0x003FB301 File Offset: 0x003F9501
		[NullableContext(1)]
		public static TowerDefenceRankShowNameResponse Create()
		{
			return new TowerDefenceRankShowNameResponse();
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x0601B60E RID: 112142 RVA: 0x003FB308 File Offset: 0x003F9508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0601B60F RID: 112143 RVA: 0x003FB30B File Offset: 0x003F950B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRankShowNameResponse.Descriptor;
			}
		}

		// Token: 0x0601B610 RID: 112144 RVA: 0x003FB312 File Offset: 0x003F9512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse()
		{
		}

		// Token: 0x0601B611 RID: 112145 RVA: 0x003FB31A File Offset: 0x003F951A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse(TowerDefenceRankShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B612 RID: 112146 RVA: 0x003FB33F File Offset: 0x003F953F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse Clone()
		{
			return new TowerDefenceRankShowNameResponse(this);
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0601B613 RID: 112147 RVA: 0x003FB347 File Offset: 0x003F9547
		// (set) Token: 0x0601B614 RID: 112148 RVA: 0x003FB34F File Offset: 0x003F954F
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

		// Token: 0x0601B615 RID: 112149 RVA: 0x003FB358 File Offset: 0x003F9558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRankShowNameResponse);
		}

		// Token: 0x0601B616 RID: 112150 RVA: 0x003FB366 File Offset: 0x003F9566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRankShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B617 RID: 112151 RVA: 0x003FB394 File Offset: 0x003F9594
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

		// Token: 0x0601B618 RID: 112152 RVA: 0x003FB3D9 File Offset: 0x003F95D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B619 RID: 112153 RVA: 0x003FB3E6 File Offset: 0x003F95E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B61A RID: 112154 RVA: 0x003FB3EF File Offset: 0x003F95EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B61B RID: 112155 RVA: 0x003FB424 File Offset: 0x003F9624
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

		// Token: 0x0601B61C RID: 112156 RVA: 0x003FB462 File Offset: 0x003F9662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRankShowNameResponse other)
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

		// Token: 0x0601B61D RID: 112157 RVA: 0x003FB493 File Offset: 0x003F9693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B61E RID: 112158 RVA: 0x003FB49C File Offset: 0x003F969C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F73 RID: 40819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F74 RID: 40820
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009F75 RID: 40821
		private ErrorCode errorCode_;
	}
}
