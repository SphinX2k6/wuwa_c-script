using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001397 RID: 5015
	[NetMessage(EMessageId.TowerApplyFloorDataResponse)]
	public sealed class TowerApplyFloorDataResponse : IMessage<TowerApplyFloorDataResponse>, IMessage, IEquatable<TowerApplyFloorDataResponse>, IDeepCloneable<TowerApplyFloorDataResponse>, IBufferMessage
	{
		// Token: 0x0601A9C4 RID: 108996 RVA: 0x003DC269 File Offset: 0x003DA469
		[NullableContext(1)]
		public static TowerApplyFloorDataResponse Create()
		{
			return new TowerApplyFloorDataResponse();
		}

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x0601A9C5 RID: 108997 RVA: 0x003DC270 File Offset: 0x003DA470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x0601A9C6 RID: 108998 RVA: 0x003DC273 File Offset: 0x003DA473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerApplyFloorDataResponse.Descriptor;
			}
		}

		// Token: 0x0601A9C7 RID: 108999 RVA: 0x003DC27A File Offset: 0x003DA47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse()
		{
		}

		// Token: 0x0601A9C8 RID: 109000 RVA: 0x003DC282 File Offset: 0x003DA482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse(TowerApplyFloorDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9C9 RID: 109001 RVA: 0x003DC2B3 File Offset: 0x003DA4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse Clone()
		{
			return new TowerApplyFloorDataResponse(this);
		}

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x0601A9CA RID: 109002 RVA: 0x003DC2BB File Offset: 0x003DA4BB
		// (set) Token: 0x0601A9CB RID: 109003 RVA: 0x003DC2C3 File Offset: 0x003DA4C3
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

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x0601A9CC RID: 109004 RVA: 0x003DC2CC File Offset: 0x003DA4CC
		// (set) Token: 0x0601A9CD RID: 109005 RVA: 0x003DC2D4 File Offset: 0x003DA4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x003DC2DD File Offset: 0x003DA4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerApplyFloorDataResponse);
		}

		// Token: 0x0601A9CF RID: 109007 RVA: 0x003DC2EB File Offset: 0x003DA4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerApplyFloorDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9D0 RID: 109008 RVA: 0x003DC32C File Offset: 0x003DA52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A9D1 RID: 109009 RVA: 0x003DC38A File Offset: 0x003DA58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9D2 RID: 109010 RVA: 0x003DC397 File Offset: 0x003DA597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9D3 RID: 109011 RVA: 0x003DC3A0 File Offset: 0x003DA5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.NeedUpdateSeason);
			}
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

		// Token: 0x0601A9D4 RID: 109012 RVA: 0x003DC3FC File Offset: 0x003DA5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A9D5 RID: 109013 RVA: 0x003DC448 File Offset: 0x003DA648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerApplyFloorDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A9D6 RID: 109014 RVA: 0x003DC498 File Offset: 0x003DA698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9D7 RID: 109015 RVA: 0x003DC4A4 File Offset: 0x003DA6A4
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
					if (num != 64U)
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
					this.NeedUpdateSeason = input.ReadBool();
				}
			}
		}

		// Token: 0x04009A9E RID: 39582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A9F RID: 39583
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009AA0 RID: 39584
		private ErrorCode errorCode_;

		// Token: 0x04009AA1 RID: 39585
		public const int NeedUpdateSeasonFieldNumber = 6;

		// Token: 0x04009AA2 RID: 39586
		private bool needUpdateSeason_;
	}
}
