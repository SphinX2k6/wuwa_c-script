using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F21 RID: 3873
	public sealed class ReviveRoleInformation : IMessage<ReviveRoleInformation>, IMessage, IEquatable<ReviveRoleInformation>, IDeepCloneable<ReviveRoleInformation>, IBufferMessage
	{
		// Token: 0x06014C11 RID: 85009 RVA: 0x003037D9 File Offset: 0x003019D9
		[NullableContext(1)]
		public static ReviveRoleInformation Create()
		{
			return new ReviveRoleInformation();
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x06014C12 RID: 85010 RVA: 0x003037E0 File Offset: 0x003019E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReviveRoleInformation> Parser
		{
			get
			{
				return ReviveRoleInformation._parser;
			}
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x06014C13 RID: 85011 RVA: 0x003037E7 File Offset: 0x003019E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x06014C14 RID: 85012 RVA: 0x003037EA File Offset: 0x003019EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRoleInformation.Descriptor;
			}
		}

		// Token: 0x06014C15 RID: 85013 RVA: 0x003037F1 File Offset: 0x003019F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation()
		{
		}

		// Token: 0x06014C16 RID: 85014 RVA: 0x003037FC File Offset: 0x003019FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation(ReviveRoleInformation other) : this()
		{
			this.entityId_ = other.entityId_;
			this.curHpAttribute_ = ((other.curHpAttribute_ != null) ? other.curHpAttribute_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C17 RID: 85015 RVA: 0x00303848 File Offset: 0x00301A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation Clone()
		{
			return new ReviveRoleInformation(this);
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x06014C18 RID: 85016 RVA: 0x00303850 File Offset: 0x00301A50
		// (set) Token: 0x06014C19 RID: 85017 RVA: 0x00303858 File Offset: 0x00301A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x06014C1A RID: 85018 RVA: 0x00303861 File Offset: 0x00301A61
		// (set) Token: 0x06014C1B RID: 85019 RVA: 0x00303869 File Offset: 0x00301A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData CurHpAttribute
		{
			get
			{
				return this.curHpAttribute_;
			}
			set
			{
				this.curHpAttribute_ = value;
			}
		}

		// Token: 0x06014C1C RID: 85020 RVA: 0x00303872 File Offset: 0x00301A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRoleInformation);
		}

		// Token: 0x06014C1D RID: 85021 RVA: 0x00303880 File Offset: 0x00301A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRoleInformation other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.CurHpAttribute, other.CurHpAttribute) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C1E RID: 85022 RVA: 0x003038D0 File Offset: 0x00301AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.curHpAttribute_ != null)
			{
				num ^= this.CurHpAttribute.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C1F RID: 85023 RVA: 0x00303925 File Offset: 0x00301B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C20 RID: 85024 RVA: 0x00303932 File Offset: 0x00301B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C21 RID: 85025 RVA: 0x0030393C File Offset: 0x00301B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.curHpAttribute_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CurHpAttribute);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C22 RID: 85026 RVA: 0x00303994 File Offset: 0x00301B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.curHpAttribute_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurHpAttribute);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C23 RID: 85027 RVA: 0x003039EC File Offset: 0x00301BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveRoleInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.curHpAttribute_ != null)
			{
				if (this.curHpAttribute_ == null)
				{
					this.CurHpAttribute = new GameplayAttributeData();
				}
				this.CurHpAttribute.MergeFrom(other.CurHpAttribute);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C24 RID: 85028 RVA: 0x00303A54 File Offset: 0x00301C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C25 RID: 85029 RVA: 0x00303A60 File Offset: 0x00301C60
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.curHpAttribute_ == null)
						{
							this.CurHpAttribute = new GameplayAttributeData();
						}
						input.ReadMessage(this.CurHpAttribute);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007DC1 RID: 32193
		private static readonly MessageParser<ReviveRoleInformation> _parser = new MessageParser<ReviveRoleInformation>(() => new ReviveRoleInformation());

		// Token: 0x04007DC2 RID: 32194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DC3 RID: 32195
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04007DC4 RID: 32196
		private long entityId_;

		// Token: 0x04007DC5 RID: 32197
		public const int CurHpAttributeFieldNumber = 2;

		// Token: 0x04007DC6 RID: 32198
		private GameplayAttributeData curHpAttribute_;
	}
}
