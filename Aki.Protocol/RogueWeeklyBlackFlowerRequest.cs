using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001020 RID: 4128
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerRequest)]
	public sealed class RogueWeeklyBlackFlowerRequest : IMessage<RogueWeeklyBlackFlowerRequest>, IMessage, IEquatable<RogueWeeklyBlackFlowerRequest>, IDeepCloneable<RogueWeeklyBlackFlowerRequest>, IBufferMessage
	{
		// Token: 0x0601616E RID: 90478 RVA: 0x0033622C File Offset: 0x0033442C
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerRequest Create()
		{
			return new RogueWeeklyBlackFlowerRequest();
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x0601616F RID: 90479 RVA: 0x00336233 File Offset: 0x00334433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x06016170 RID: 90480 RVA: 0x00336236 File Offset: 0x00334436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerRequest.Descriptor;
			}
		}

		// Token: 0x06016171 RID: 90481 RVA: 0x0033623D File Offset: 0x0033443D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest()
		{
		}

		// Token: 0x06016172 RID: 90482 RVA: 0x00336248 File Offset: 0x00334448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest(RogueWeeklyBlackFlowerRequest other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.ret_ = other.ret_;
			this.isDouble_ = other.isDouble_;
			this.silentAreaId_ = other.silentAreaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016173 RID: 90483 RVA: 0x0033629C File Offset: 0x0033449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest Clone()
		{
			return new RogueWeeklyBlackFlowerRequest(this);
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x06016174 RID: 90484 RVA: 0x003362A4 File Offset: 0x003344A4
		// (set) Token: 0x06016175 RID: 90485 RVA: 0x003362AC File Offset: 0x003344AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x06016176 RID: 90486 RVA: 0x003362B5 File Offset: 0x003344B5
		// (set) Token: 0x06016177 RID: 90487 RVA: 0x003362BD File Offset: 0x003344BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ret
		{
			get
			{
				return this.ret_;
			}
			set
			{
				this.ret_ = value;
			}
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x06016178 RID: 90488 RVA: 0x003362C6 File Offset: 0x003344C6
		// (set) Token: 0x06016179 RID: 90489 RVA: 0x003362CE File Offset: 0x003344CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDouble
		{
			get
			{
				return this.isDouble_;
			}
			set
			{
				this.isDouble_ = value;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x0601617A RID: 90490 RVA: 0x003362D7 File Offset: 0x003344D7
		// (set) Token: 0x0601617B RID: 90491 RVA: 0x003362DF File Offset: 0x003344DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SilentAreaId
		{
			get
			{
				return this.silentAreaId_;
			}
			set
			{
				this.silentAreaId_ = value;
			}
		}

		// Token: 0x0601617C RID: 90492 RVA: 0x003362E8 File Offset: 0x003344E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerRequest);
		}

		// Token: 0x0601617D RID: 90493 RVA: 0x003362F8 File Offset: 0x003344F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerRequest other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.Ret == other.Ret && this.IsDouble == other.IsDouble && this.SilentAreaId == other.SilentAreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601617E RID: 90494 RVA: 0x00336364 File Offset: 0x00334564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.Ret)
			{
				num ^= this.Ret.GetHashCode();
			}
			if (this.IsDouble)
			{
				num ^= this.IsDouble.GetHashCode();
			}
			if (this.SilentAreaId != 0)
			{
				num ^= this.SilentAreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601617F RID: 90495 RVA: 0x003363EE File Offset: 0x003345EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016180 RID: 90496 RVA: 0x003363FB File Offset: 0x003345FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016181 RID: 90497 RVA: 0x00336404 File Offset: 0x00334604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.IsDouble)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsDouble);
			}
			if (this.Ret)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Ret);
			}
			if (this.SilentAreaId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SilentAreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016182 RID: 90498 RVA: 0x00336494 File Offset: 0x00334694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.Ret)
			{
				num += 2;
			}
			if (this.IsDouble)
			{
				num += 2;
			}
			if (this.SilentAreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SilentAreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016183 RID: 90499 RVA: 0x00336504 File Offset: 0x00334704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBlackFlowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.Ret)
			{
				this.Ret = other.Ret;
			}
			if (other.IsDouble)
			{
				this.IsDouble = other.IsDouble;
			}
			if (other.SilentAreaId != 0)
			{
				this.SilentAreaId = other.SilentAreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016184 RID: 90500 RVA: 0x0033657C File Offset: 0x0033477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016185 RID: 90501 RVA: 0x00336588 File Offset: 0x00334788
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.IsDouble = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Ret = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.SilentAreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040084BC RID: 33980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084BD RID: 33981
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x040084BE RID: 33982
		private int entityConfigId_;

		// Token: 0x040084BF RID: 33983
		public const int RetFieldNumber = 10;

		// Token: 0x040084C0 RID: 33984
		private bool ret_;

		// Token: 0x040084C1 RID: 33985
		public const int IsDoubleFieldNumber = 8;

		// Token: 0x040084C2 RID: 33986
		private bool isDouble_;

		// Token: 0x040084C3 RID: 33987
		public const int SilentAreaIdFieldNumber = 15;

		// Token: 0x040084C4 RID: 33988
		private int silentAreaId_;
	}
}
