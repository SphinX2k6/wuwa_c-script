using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C4 RID: 1476
	[NetMessage(EMessageId.FloroRanchPlayWeeklyNotify)]
	public sealed class FloroRanchPlayWeeklyNotify : IMessage<FloroRanchPlayWeeklyNotify>, IMessage, IEquatable<FloroRanchPlayWeeklyNotify>, IDeepCloneable<FloroRanchPlayWeeklyNotify>, IBufferMessage
	{
		// Token: 0x0600891F RID: 35103 RVA: 0x0014C358 File Offset: 0x0014A558
		[NullableContext(1)]
		public static FloroRanchPlayWeeklyNotify Create()
		{
			return new FloroRanchPlayWeeklyNotify();
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06008920 RID: 35104 RVA: 0x0014C35F File Offset: 0x0014A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x0014C362 File Offset: 0x0014A562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayWeeklyNotify.Descriptor;
			}
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x0014C369 File Offset: 0x0014A569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify()
		{
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x0014C374 File Offset: 0x0014A574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify(FloroRanchPlayWeeklyNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x0014C3CC File Offset: 0x0014A5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify Clone()
		{
			return new FloroRanchPlayWeeklyNotify(this);
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x0014C3D4 File Offset: 0x0014A5D4
		// (set) Token: 0x06008926 RID: 35110 RVA: 0x0014C3DC File Offset: 0x0014A5DC
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06008927 RID: 35111 RVA: 0x0014C3E5 File Offset: 0x0014A5E5
		// (set) Token: 0x06008928 RID: 35112 RVA: 0x0014C3ED File Offset: 0x0014A5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06008929 RID: 35113 RVA: 0x0014C3F6 File Offset: 0x0014A5F6
		// (set) Token: 0x0600892A RID: 35114 RVA: 0x0014C3FE File Offset: 0x0014A5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x0014C407 File Offset: 0x0014A607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayWeeklyNotify);
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x0014C418 File Offset: 0x0014A618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayWeeklyNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x0014C478 File Offset: 0x0014A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x0014C4E6 File Offset: 0x0014A6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x0014C4F3 File Offset: 0x0014A6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x0014C4FC File Offset: 0x0014A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x0014C574 File Offset: 0x0014A774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x0014C5E4 File Offset: 0x0014A7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayWeeklyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new FloroRanchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x0014C660 File Offset: 0x0014A860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x0014C66C File Offset: 0x0014A86C
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
					if (num != 32U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.playerInfo_ == null)
							{
								this.PlayerInfo = new FloroRanchPlayerInfo();
							}
							input.ReadMessage(this.PlayerInfo);
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004400 RID: 17408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004401 RID: 17409
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004402 RID: 17410
		private int activityId_;

		// Token: 0x04004403 RID: 17411
		public const int SubInsIdFieldNumber = 3;

		// Token: 0x04004404 RID: 17412
		private int subInsId_;

		// Token: 0x04004405 RID: 17413
		public const int PlayerInfoFieldNumber = 15;

		// Token: 0x04004406 RID: 17414
		private FloroRanchPlayerInfo playerInfo_;
	}
}
