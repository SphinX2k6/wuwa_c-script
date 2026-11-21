using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000035 RID: 53
	[NetMessage(EMessageId.AbyssPluginPutRequest)]
	public sealed class AbyssPluginPutRequest : IMessage<AbyssPluginPutRequest>, IMessage, IEquatable<AbyssPluginPutRequest>, IDeepCloneable<AbyssPluginPutRequest>, IBufferMessage
	{
		// Token: 0x060012E4 RID: 4836 RVA: 0x00033AD1 File Offset: 0x00031CD1
		[NullableContext(1)]
		public static AbyssPluginPutRequest Create()
		{
			return new AbyssPluginPutRequest();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00033AD8 File Offset: 0x00031CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00033ADB File Offset: 0x00031CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginPutRequest.Descriptor;
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00033AE2 File Offset: 0x00031CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest()
		{
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00033AF5 File Offset: 0x00031CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest(AbyssPluginPutRequest other) : this()
		{
			this.littleRoleId_ = other.littleRoleId_;
			this.equipItems_ = other.equipItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00033B2B File Offset: 0x00031D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest Clone()
		{
			return new AbyssPluginPutRequest(this);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00033B33 File Offset: 0x00031D33
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x00033B3B File Offset: 0x00031D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LittleRoleId
		{
			get
			{
				return this.littleRoleId_;
			}
			set
			{
				this.littleRoleId_ = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00033B44 File Offset: 0x00031D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipItems
		{
			get
			{
				return this.equipItems_;
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00033B4C File Offset: 0x00031D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginPutRequest);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00033B5C File Offset: 0x00031D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginPutRequest other)
		{
			return other != null && (other == this || (this.LittleRoleId == other.LittleRoleId && this.equipItems_.Equals(other.equipItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00033BAC File Offset: 0x00031DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LittleRoleId != 0)
			{
				num ^= this.LittleRoleId.GetHashCode();
			}
			num ^= this.equipItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00033BF9 File Offset: 0x00031DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00033C06 File Offset: 0x00031E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00033C10 File Offset: 0x00031E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LittleRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LittleRoleId);
			}
			this.equipItems_.WriteTo(ref output, AbyssPluginPutRequest._repeated_equipItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00033C60 File Offset: 0x00031E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LittleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LittleRoleId);
			}
			num += this.equipItems_.CalculateSize(AbyssPluginPutRequest._repeated_equipItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00033CB4 File Offset: 0x00031EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginPutRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LittleRoleId != 0)
			{
				this.LittleRoleId = other.LittleRoleId;
			}
			this.equipItems_.Add(other.equipItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00033D01 File Offset: 0x00031F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00033D0C File Offset: 0x00031F0C
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
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.equipItems_.AddEntriesFrom(ref input, AbyssPluginPutRequest._repeated_equipItems_codec);
					}
				}
				else
				{
					this.LittleRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002036 RID: 8246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002037 RID: 8247
		public const int LittleRoleIdFieldNumber = 6;

		// Token: 0x04002038 RID: 8248
		private int littleRoleId_;

		// Token: 0x04002039 RID: 8249
		public const int EquipItemsFieldNumber = 13;

		// Token: 0x0400203A RID: 8250
		private static readonly FieldCodec<int> _repeated_equipItems_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400203B RID: 8251
		private readonly RepeatedField<int> equipItems_ = new RepeatedField<int>();
	}
}
