using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001520 RID: 5408
	[NetMessage(EMessageId.WorldTeamPlayerInfoChangeNotify)]
	public sealed class WorldTeamPlayerInfoChangeNotify : IMessage<WorldTeamPlayerInfoChangeNotify>, IMessage, IEquatable<WorldTeamPlayerInfoChangeNotify>, IDeepCloneable<WorldTeamPlayerInfoChangeNotify>, IBufferMessage
	{
		// Token: 0x0601C941 RID: 117057 RVA: 0x004207E1 File Offset: 0x0041E9E1
		[NullableContext(1)]
		public static WorldTeamPlayerInfoChangeNotify Create()
		{
			return new WorldTeamPlayerInfoChangeNotify();
		}

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x0601C942 RID: 117058 RVA: 0x004207E8 File Offset: 0x0041E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x0601C943 RID: 117059 RVA: 0x004207EB File Offset: 0x0041E9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerInfoChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601C944 RID: 117060 RVA: 0x004207F2 File Offset: 0x0041E9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfoChangeNotify()
		{
		}

		// Token: 0x0601C945 RID: 117061 RVA: 0x00420808 File Offset: 0x0041EA08
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

		// Token: 0x0601C946 RID: 117062 RVA: 0x0042085C File Offset: 0x0041EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfoChangeNotify Clone()
		{
			return new WorldTeamPlayerInfoChangeNotify(this);
		}

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x0601C947 RID: 117063 RVA: 0x00420864 File Offset: 0x0041EA64
		// (set) Token: 0x0601C948 RID: 117064 RVA: 0x0042086C File Offset: 0x0041EA6C
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

		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x0601C949 RID: 117065 RVA: 0x00420875 File Offset: 0x0041EA75
		// (set) Token: 0x0601C94A RID: 117066 RVA: 0x0042087D File Offset: 0x0041EA7D
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

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x0601C94B RID: 117067 RVA: 0x00420886 File Offset: 0x0041EA86
		// (set) Token: 0x0601C94C RID: 117068 RVA: 0x0042088E File Offset: 0x0041EA8E
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

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x0601C94D RID: 117069 RVA: 0x00420897 File Offset: 0x0041EA97
		// (set) Token: 0x0601C94E RID: 117070 RVA: 0x0042089F File Offset: 0x0041EA9F
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

		// Token: 0x0601C94F RID: 117071 RVA: 0x004208B2 File Offset: 0x0041EAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerInfoChangeNotify);
		}

		// Token: 0x0601C950 RID: 117072 RVA: 0x004208C0 File Offset: 0x0041EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerInfoChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ChangeType == other.ChangeType && this.IntValue == other.IntValue && !(this.StringValue != other.StringValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C951 RID: 117073 RVA: 0x00420930 File Offset: 0x0041EB30
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

		// Token: 0x0601C952 RID: 117074 RVA: 0x004209C2 File Offset: 0x0041EBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C953 RID: 117075 RVA: 0x004209CF File Offset: 0x0041EBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C954 RID: 117076 RVA: 0x004209D8 File Offset: 0x0041EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.StringValue.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.StringValue);
			}
			if (this.IntValue != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IntValue);
			}
			if (this.ChangeType != WorldTeamPlayerChangeType.Name)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ChangeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C955 RID: 117077 RVA: 0x00420A70 File Offset: 0x0041EC70
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

		// Token: 0x0601C956 RID: 117078 RVA: 0x00420AFC File Offset: 0x0041ECFC
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

		// Token: 0x0601C957 RID: 117079 RVA: 0x00420B79 File Offset: 0x0041ED79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C958 RID: 117080 RVA: 0x00420B84 File Offset: 0x0041ED84
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.StringValue = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 72U)
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A371 RID: 41841
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A372 RID: 41842
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x0400A373 RID: 41843
		private int playerId_;

		// Token: 0x0400A374 RID: 41844
		public const int ChangeTypeFieldNumber = 10;

		// Token: 0x0400A375 RID: 41845
		private WorldTeamPlayerChangeType changeType_;

		// Token: 0x0400A376 RID: 41846
		public const int IntValueFieldNumber = 9;

		// Token: 0x0400A377 RID: 41847
		private int intValue_;

		// Token: 0x0400A378 RID: 41848
		public const int StringValueFieldNumber = 6;

		// Token: 0x0400A379 RID: 41849
		private string stringValue_ = "";
	}
}
