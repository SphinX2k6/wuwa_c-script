using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A0 RID: 160
	[NetMessage(EMessageId.AddCombineEntitiesRelationNotify)]
	public sealed class AddCombineEntitiesRelationNotify : IMessage<AddCombineEntitiesRelationNotify>, IMessage, IEquatable<AddCombineEntitiesRelationNotify>, IDeepCloneable<AddCombineEntitiesRelationNotify>, IBufferMessage
	{
		// Token: 0x06001C72 RID: 7282 RVA: 0x0004F02D File Offset: 0x0004D22D
		[NullableContext(1)]
		public static AddCombineEntitiesRelationNotify Create()
		{
			return new AddCombineEntitiesRelationNotify();
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0004F034 File Offset: 0x0004D234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0004F037 File Offset: 0x0004D237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddCombineEntitiesRelationNotify.Descriptor;
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0004F03E File Offset: 0x0004D23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify()
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0004F048 File Offset: 0x0004D248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify(AddCombineEntitiesRelationNotify other) : this()
		{
			this.combinePartInfo_ = ((other.combinePartInfo_ != null) ? other.combinePartInfo_.Clone() : null);
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0004F094 File Offset: 0x0004D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify Clone()
		{
			return new AddCombineEntitiesRelationNotify(this);
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0004F09C File Offset: 0x0004D29C
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0004F0A4 File Offset: 0x0004D2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo CombinePartInfo
		{
			get
			{
				return this.combinePartInfo_;
			}
			set
			{
				this.combinePartInfo_ = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0004F0AD File Offset: 0x0004D2AD
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0004F0B5 File Offset: 0x0004D2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntity
		{
			get
			{
				return this.targetEntity_;
			}
			set
			{
				this.targetEntity_ = value;
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0004F0BE File Offset: 0x0004D2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddCombineEntitiesRelationNotify);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0004F0CC File Offset: 0x0004D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddCombineEntitiesRelationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombinePartInfo, other.CombinePartInfo) && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0004F11C File Offset: 0x0004D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combinePartInfo_ != null)
			{
				num ^= this.CombinePartInfo.GetHashCode();
			}
			if (this.TargetEntity != 0L)
			{
				num ^= this.TargetEntity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0004F171 File Offset: 0x0004D371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0004F17E File Offset: 0x0004D37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0004F188 File Offset: 0x0004D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetEntity);
			}
			if (this.combinePartInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CombinePartInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combinePartInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombinePartInfo);
			}
			if (this.TargetEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0004F23C File Offset: 0x0004D43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddCombineEntitiesRelationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combinePartInfo_ != null)
			{
				if (this.combinePartInfo_ == null)
				{
					this.CombinePartInfo = new CombinePartInfo();
				}
				this.CombinePartInfo.MergeFrom(other.CombinePartInfo);
			}
			if (other.TargetEntity != 0L)
			{
				this.TargetEntity = other.TargetEntity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0004F2B0 File Offset: 0x0004D4B0
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combinePartInfo_ == null)
						{
							this.CombinePartInfo = new CombinePartInfo();
						}
						input.ReadMessage(this.CombinePartInfo);
					}
				}
				else
				{
					this.TargetEntity = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400232B RID: 9003
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400232C RID: 9004
		public const int CombinePartInfoFieldNumber = 13;

		// Token: 0x0400232D RID: 9005
		private CombinePartInfo combinePartInfo_;

		// Token: 0x0400232E RID: 9006
		public const int TargetEntityFieldNumber = 3;

		// Token: 0x0400232F RID: 9007
		private long targetEntity_;
	}
}
