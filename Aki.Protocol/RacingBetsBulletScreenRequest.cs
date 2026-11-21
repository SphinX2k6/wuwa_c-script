using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3A RID: 3642
	[NetMessage(EMessageId.RacingBetsBulletScreenRequest)]
	public sealed class RacingBetsBulletScreenRequest : IMessage<RacingBetsBulletScreenRequest>, IMessage, IEquatable<RacingBetsBulletScreenRequest>, IDeepCloneable<RacingBetsBulletScreenRequest>, IBufferMessage
	{
		// Token: 0x0601395F RID: 80223 RVA: 0x002D9ACC File Offset: 0x002D7CCC
		[NullableContext(1)]
		public static RacingBetsBulletScreenRequest Create()
		{
			return new RacingBetsBulletScreenRequest();
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x06013960 RID: 80224 RVA: 0x002D9AD3 File Offset: 0x002D7CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x06013961 RID: 80225 RVA: 0x002D9AD6 File Offset: 0x002D7CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsBulletScreenRequest.Descriptor;
			}
		}

		// Token: 0x06013962 RID: 80226 RVA: 0x002D9ADD File Offset: 0x002D7CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest()
		{
		}

		// Token: 0x06013963 RID: 80227 RVA: 0x002D9AE8 File Offset: 0x002D7CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest(RacingBetsBulletScreenRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.bulletScreenId_ = other.bulletScreenId_;
			this.actionIndex_ = other.actionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013964 RID: 80228 RVA: 0x002D9B3C File Offset: 0x002D7D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest Clone()
		{
			return new RacingBetsBulletScreenRequest(this);
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x06013965 RID: 80229 RVA: 0x002D9B44 File Offset: 0x002D7D44
		// (set) Token: 0x06013966 RID: 80230 RVA: 0x002D9B4C File Offset: 0x002D7D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x06013967 RID: 80231 RVA: 0x002D9B55 File Offset: 0x002D7D55
		// (set) Token: 0x06013968 RID: 80232 RVA: 0x002D9B5D File Offset: 0x002D7D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x06013969 RID: 80233 RVA: 0x002D9B66 File Offset: 0x002D7D66
		// (set) Token: 0x0601396A RID: 80234 RVA: 0x002D9B6E File Offset: 0x002D7D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletScreenId
		{
			get
			{
				return this.bulletScreenId_;
			}
			set
			{
				this.bulletScreenId_ = value;
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x0601396B RID: 80235 RVA: 0x002D9B77 File Offset: 0x002D7D77
		// (set) Token: 0x0601396C RID: 80236 RVA: 0x002D9B7F File Offset: 0x002D7D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionIndex
		{
			get
			{
				return this.actionIndex_;
			}
			set
			{
				this.actionIndex_ = value;
			}
		}

		// Token: 0x0601396D RID: 80237 RVA: 0x002D9B88 File Offset: 0x002D7D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsBulletScreenRequest);
		}

		// Token: 0x0601396E RID: 80238 RVA: 0x002D9B98 File Offset: 0x002D7D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsBulletScreenRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.BulletScreenId == other.BulletScreenId && this.ActionIndex == other.ActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601396F RID: 80239 RVA: 0x002D9C04 File Offset: 0x002D7E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.BulletScreenId != 0)
			{
				num ^= this.BulletScreenId.GetHashCode();
			}
			if (this.ActionIndex != 0)
			{
				num ^= this.ActionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013970 RID: 80240 RVA: 0x002D9C8E File Offset: 0x002D7E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013971 RID: 80241 RVA: 0x002D9C9B File Offset: 0x002D7E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013972 RID: 80242 RVA: 0x002D9CA4 File Offset: 0x002D7EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletScreenId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BulletScreenId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActionIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActionIndex);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013973 RID: 80243 RVA: 0x002D9D34 File Offset: 0x002D7F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.BulletScreenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletScreenId);
			}
			if (this.ActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013974 RID: 80244 RVA: 0x002D9DBC File Offset: 0x002D7FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsBulletScreenRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.BulletScreenId != 0)
			{
				this.BulletScreenId = other.BulletScreenId;
			}
			if (other.ActionIndex != 0)
			{
				this.ActionIndex = other.ActionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013975 RID: 80245 RVA: 0x002D9E34 File Offset: 0x002D8034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013976 RID: 80246 RVA: 0x002D9E40 File Offset: 0x002D8040
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BulletScreenId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ActionIndex = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007868 RID: 30824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007869 RID: 30825
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400786A RID: 30826
		private int activityId_;

		// Token: 0x0400786B RID: 30827
		public const int LegMatchIdFieldNumber = 2;

		// Token: 0x0400786C RID: 30828
		private int legMatchId_;

		// Token: 0x0400786D RID: 30829
		public const int BulletScreenIdFieldNumber = 1;

		// Token: 0x0400786E RID: 30830
		private int bulletScreenId_;

		// Token: 0x0400786F RID: 30831
		public const int ActionIndexFieldNumber = 7;

		// Token: 0x04007870 RID: 30832
		private int actionIndex_;
	}
}
