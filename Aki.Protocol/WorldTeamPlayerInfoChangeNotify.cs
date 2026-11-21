using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001596 RID: 5526
	[NetMessage(EMessageId.WorldTeamPlayerInfoChangeNotify)]
	public sealed class WorldTeamPlayerInfoChangeNotify : IMessage<WorldTeamPlayerInfoChangeNotify>, IMessage, IEquatable<WorldTeamPlayerInfoChangeNotify>, IDeepCloneable<WorldTeamPlayerInfoChangeNotify>, IBufferMessage
	{
		// Token: 0x0601D408 RID: 119816 RVA: 0x0043C29D File Offset: 0x0043A49D
		[NullableContext(1)]
		public static WorldTeamPlayerInfoChangeNotify Create()
		{
			return new WorldTeamPlayerInfoChangeNotify();
		}

		// Token: 0x170062F8 RID: 25336
		// (get) Token: 0x0601D409 RID: 119817 RVA: 0x0043C2A4 File Offset: 0x0043A4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x0601D40A RID: 119818 RVA: 0x0043C2A7 File Offset: 0x0043A4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerInfoChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601D40B RID: 119819 RVA: 0x0043C2AE File Offset: 0x0043A4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfoChangeNotify()
		{
		}

		// Token: 0x0601D40C RID: 119820 RVA: 0x0043C2C4 File Offset: 0x0043A4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfoChangeNotify(WorldTeamPlayerInfoChangeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.changeType_ = other.changeType_;
			this.intValue_ = other.intValue_;
			this.stringValue_ = other.stringValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D40D RID: 119821 RVA: 0x0043C318 File Offset: 0x0043A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfoChangeNotify Clone()
		{
			return new WorldTeamPlayerInfoChangeNotify(this);
		}

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x0601D40E RID: 119822 RVA: 0x0043C320 File Offset: 0x0043A520
		// (set) Token: 0x0601D40F RID: 119823 RVA: 0x0043C328 File Offset: 0x0043A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170062FB RID: 25339
		// (get) Token: 0x0601D410 RID: 119824 RVA: 0x0043C331 File Offset: 0x0043A531
		// (set) Token: 0x0601D411 RID: 119825 RVA: 0x0043C339 File Offset: 0x0043A539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerChangeType ChangeType
		{
			get
			{
				return this.changeType_;
			}
			set
			{
				this.changeType_ = value;
			}
		}

		// Token: 0x170062FC RID: 25340
		// (get) Token: 0x0601D412 RID: 119826 RVA: 0x0043C342 File Offset: 0x0043A542
		// (set) Token: 0x0601D413 RID: 119827 RVA: 0x0043C34A File Offset: 0x0043A54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IntValue
		{
			get
			{
				return this.intValue_;
			}
			set
			{
				this.intValue_ = value;
			}
		}

		// Token: 0x170062FD RID: 25341
		// (get) Token: 0x0601D414 RID: 119828 RVA: 0x0043C353 File Offset: 0x0043A553
		// (set) Token: 0x0601D415 RID: 119829 RVA: 0x0043C35B File Offset: 0x0043A55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StringValue
		{
			get
			{
				return this.stringValue_;
			}
			set
			{
				this.stringValue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601D416 RID: 119830 RVA: 0x0043C36E File Offset: 0x0043A56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerInfoChangeNotify);
		}

		// Token: 0x0601D417 RID: 119831 RVA: 0x0043C37C File Offset: 0x0043A57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerInfoChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ChangeType == other.ChangeType && this.IntValue == other.IntValue && !(this.StringValue != other.StringValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D418 RID: 119832 RVA: 0x0043C3EC File Offset: 0x0043A5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.ChangeType != WorldTeamPlayerChangeType.Name)
			{
				num ^= this.ChangeType.GetHashCode();
			}
			if (this.IntValue != 0)
			{
				num ^= this.IntValue.GetHashCode();
			}
			if (this.StringValue.Length != 0)
			{
				num ^= this.StringValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D419 RID: 119833 RVA: 0x0043C47E File Offset: 0x0043A67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x0043C48B File Offset: 0x0043A68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D41B RID: 119835 RVA: 0x0043C494 File Offset: 0x0043A694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IntValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IntValue);
			}
			if (this.ChangeType != WorldTeamPlayerChangeType.Name)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ChangeType);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this.StringValue.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.StringValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D41C RID: 119836 RVA: 0x0043C52C File Offset: 0x0043A72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.ChangeType != WorldTeamPlayerChangeType.Name)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChangeType);
			}
			if (this.IntValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntValue);
			}
			if (this.StringValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D41D RID: 119837 RVA: 0x0043C5B8 File Offset: 0x0043A7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldTeamPlayerInfoChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.ChangeType != WorldTeamPlayerChangeType.Name)
			{
				this.ChangeType = other.ChangeType;
			}
			if (other.IntValue != 0)
			{
				this.IntValue = other.IntValue;
			}
			if (other.StringValue.Length != 0)
			{
				this.StringValue = other.StringValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D41E RID: 119838 RVA: 0x0043C635 File Offset: 0x0043A835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D41F RID: 119839 RVA: 0x0043C640 File Offset: 0x0043A840
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.IntValue = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ChangeType = (WorldTeamPlayerChangeType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.StringValue = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A7CA RID: 42954
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7CB RID: 42955
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x0400A7CC RID: 42956
		private int playerId_;

		// Token: 0x0400A7CD RID: 42957
		public const int ChangeTypeFieldNumber = 10;

		// Token: 0x0400A7CE RID: 42958
		private WorldTeamPlayerChangeType changeType_;

		// Token: 0x0400A7CF RID: 42959
		public const int IntValueFieldNumber = 2;

		// Token: 0x0400A7D0 RID: 42960
		private int intValue_;

		// Token: 0x0400A7D1 RID: 42961
		public const int StringValueFieldNumber = 14;

		// Token: 0x0400A7D2 RID: 42962
		private string stringValue_ = "";
	}
}
