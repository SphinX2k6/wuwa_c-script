using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F6 RID: 1526
	public sealed class FlyEquipData : IMessage<FlyEquipData>, IMessage, IEquatable<FlyEquipData>, IDeepCloneable<FlyEquipData>, IBufferMessage
	{
		// Token: 0x06008D9D RID: 36253 RVA: 0x00157E41 File Offset: 0x00156041
		[NullableContext(1)]
		public static FlyEquipData Create()
		{
			return new FlyEquipData();
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x00157E48 File Offset: 0x00156048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlyEquipData> Parser
		{
			get
			{
				return FlyEquipData._parser;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06008D9F RID: 36255 RVA: 0x00157E4F File Offset: 0x0015604F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x00157E52 File Offset: 0x00156052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlyEquipData.Descriptor;
			}
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x00157E59 File Offset: 0x00156059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData()
		{
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x00157E6C File Offset: 0x0015606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData(FlyEquipData other) : this()
		{
			this.skinId_ = other.skinId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x00157EA2 File Offset: 0x001560A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData Clone()
		{
			return new FlyEquipData(this);
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x00157EAA File Offset: 0x001560AA
		// (set) Token: 0x06008DA5 RID: 36261 RVA: 0x00157EB2 File Offset: 0x001560B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x00157EBB File Offset: 0x001560BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x00157EC3 File Offset: 0x001560C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlyEquipData);
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x00157ED4 File Offset: 0x001560D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlyEquipData other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x00157F24 File Offset: 0x00156124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x00157F71 File Offset: 0x00156171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x00157F7E File Offset: 0x0015617E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x00157F88 File Offset: 0x00156188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			this.roleIds_.WriteTo(ref output, FlyEquipData._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x00157FD8 File Offset: 0x001561D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			num += this.roleIds_.CalculateSize(FlyEquipData._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x0015802C File Offset: 0x0015622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlyEquipData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00158079 File Offset: 0x00156279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00158084 File Offset: 0x00156284
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIds_.AddEntriesFrom(ref input, FlyEquipData._repeated_roleIds_codec);
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400457F RID: 17791
		private static readonly MessageParser<FlyEquipData> _parser = new MessageParser<FlyEquipData>(() => new FlyEquipData());

		// Token: 0x04004580 RID: 17792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004581 RID: 17793
		public const int SkinIdFieldNumber = 1;

		// Token: 0x04004582 RID: 17794
		private int skinId_;

		// Token: 0x04004583 RID: 17795
		public const int RoleIdsFieldNumber = 2;

		// Token: 0x04004584 RID: 17796
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004585 RID: 17797
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
