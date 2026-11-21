using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000081 RID: 129
	[NetMessage(EMessageId.ActiveDragonPoolResponse)]
	public sealed class ActiveDragonPoolResponse : IMessage<ActiveDragonPoolResponse>, IMessage, IEquatable<ActiveDragonPoolResponse>, IDeepCloneable<ActiveDragonPoolResponse>, IBufferMessage
	{
		// Token: 0x060018FC RID: 6396 RVA: 0x00041285 File Offset: 0x0003F485
		[NullableContext(1)]
		public static ActiveDragonPoolResponse Create()
		{
			return new ActiveDragonPoolResponse();
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x0004128C File Offset: 0x0003F48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0004128F File Offset: 0x0003F48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveDragonPoolResponse.Descriptor;
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00041296 File Offset: 0x0003F496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse()
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0004129E File Offset: 0x0003F49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse(ActiveDragonPoolResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolId_ = other.dragonPoolId_;
			this.activeStatus_ = other.activeStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000412DB File Offset: 0x0003F4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse Clone()
		{
			return new ActiveDragonPoolResponse(this);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000412E3 File Offset: 0x0003F4E3
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x000412EB File Offset: 0x0003F4EB
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000412F4 File Offset: 0x0003F4F4
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x000412FC File Offset: 0x0003F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00041305 File Offset: 0x0003F505
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0004130D File Offset: 0x0003F50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveStatus
		{
			get
			{
				return this.activeStatus_;
			}
			set
			{
				this.activeStatus_ = value;
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00041316 File Offset: 0x0003F516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveDragonPoolResponse);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00041324 File Offset: 0x0003F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveDragonPoolResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DragonPoolId == other.DragonPoolId && this.ActiveStatus == other.ActiveStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00041380 File Offset: 0x0003F580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.ActiveStatus != 0)
			{
				num ^= this.ActiveStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x000413F7 File Offset: 0x0003F5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00041404 File Offset: 0x0003F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00041410 File Offset: 0x0003F610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActiveStatus != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActiveStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00041488 File Offset: 0x0003F688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.ActiveStatus != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000414F8 File Offset: 0x0003F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActiveDragonPoolResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.ActiveStatus != 0)
			{
				this.ActiveStatus = other.ActiveStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0004155C File Offset: 0x0003F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00041568 File Offset: 0x0003F768
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
				if (num != 48U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActiveStatus = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040021EE RID: 8686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021EF RID: 8687
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040021F0 RID: 8688
		private ErrorCode errorCode_;

		// Token: 0x040021F1 RID: 8689
		public const int DragonPoolIdFieldNumber = 6;

		// Token: 0x040021F2 RID: 8690
		private int dragonPoolId_;

		// Token: 0x040021F3 RID: 8691
		public const int ActiveStatusFieldNumber = 14;

		// Token: 0x040021F4 RID: 8692
		private int activeStatus_;
	}
}
