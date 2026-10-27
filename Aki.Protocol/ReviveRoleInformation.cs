using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F31 RID: 3889
	public sealed class ReviveRoleInformation : IMessage<ReviveRoleInformation>, IMessage, IEquatable<ReviveRoleInformation>, IDeepCloneable<ReviveRoleInformation>, IBufferMessage
	{
		// Token: 0x06014CF6 RID: 85238 RVA: 0x00304E95 File Offset: 0x00303095
		[NullableContext(1)]
		public static ReviveRoleInformation Create()
		{
			return new ReviveRoleInformation();
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x06014CF7 RID: 85239 RVA: 0x00304E9C File Offset: 0x0030309C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReviveRoleInformation> Parser
		{
			get
			{
				return ReviveRoleInformation._parser;
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x06014CF8 RID: 85240 RVA: 0x00304EA3 File Offset: 0x003030A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x06014CF9 RID: 85241 RVA: 0x00304EA6 File Offset: 0x003030A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRoleInformation.Descriptor;
			}
		}

		// Token: 0x06014CFA RID: 85242 RVA: 0x00304EAD File Offset: 0x003030AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation()
		{
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x00304EB8 File Offset: 0x003030B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation(ReviveRoleInformation other) : this()
		{
			this.entityId_ = other.entityId_;
			this.curHpAttribute_ = ((other.curHpAttribute_ != null) ? other.curHpAttribute_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CFC RID: 85244 RVA: 0x00304F04 File Offset: 0x00303104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRoleInformation Clone()
		{
			return new ReviveRoleInformation(this);
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x06014CFD RID: 85245 RVA: 0x00304F0C File Offset: 0x0030310C
		// (set) Token: 0x06014CFE RID: 85246 RVA: 0x00304F14 File Offset: 0x00303114
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

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x06014CFF RID: 85247 RVA: 0x00304F1D File Offset: 0x0030311D
		// (set) Token: 0x06014D00 RID: 85248 RVA: 0x00304F25 File Offset: 0x00303125
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

		// Token: 0x06014D01 RID: 85249 RVA: 0x00304F2E File Offset: 0x0030312E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRoleInformation);
		}

		// Token: 0x06014D02 RID: 85250 RVA: 0x00304F3C File Offset: 0x0030313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRoleInformation other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.CurHpAttribute, other.CurHpAttribute) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D03 RID: 85251 RVA: 0x00304F8C File Offset: 0x0030318C
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

		// Token: 0x06014D04 RID: 85252 RVA: 0x00304FE1 File Offset: 0x003031E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D05 RID: 85253 RVA: 0x00304FEE File Offset: 0x003031EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D06 RID: 85254 RVA: 0x00304FF8 File Offset: 0x003031F8
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

		// Token: 0x06014D07 RID: 85255 RVA: 0x00305050 File Offset: 0x00303250
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

		// Token: 0x06014D08 RID: 85256 RVA: 0x003050A8 File Offset: 0x003032A8
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

		// Token: 0x06014D09 RID: 85257 RVA: 0x00305110 File Offset: 0x00303310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D0A RID: 85258 RVA: 0x0030511C File Offset: 0x0030331C
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

		// Token: 0x04007D97 RID: 32151
		private static readonly MessageParser<ReviveRoleInformation> _parser = new MessageParser<ReviveRoleInformation>(() => new ReviveRoleInformation());

		// Token: 0x04007D98 RID: 32152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D99 RID: 32153
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04007D9A RID: 32154
		private long entityId_;

		// Token: 0x04007D9B RID: 32155
		public const int CurHpAttributeFieldNumber = 2;

		// Token: 0x04007D9C RID: 32156
		private GameplayAttributeData curHpAttribute_;
	}
}
