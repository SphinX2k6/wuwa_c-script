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
		// Token: 0x060012B9 RID: 4793 RVA: 0x0003351D File Offset: 0x0003171D
		[NullableContext(1)]
		public static AbyssPluginPutRequest Create()
		{
			return new AbyssPluginPutRequest();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00033524 File Offset: 0x00031724
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
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00033527 File Offset: 0x00031727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginPutRequest.Descriptor;
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0003352E File Offset: 0x0003172E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest()
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00033541 File Offset: 0x00031741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest(AbyssPluginPutRequest other) : this()
		{
			this.littleRoleId_ = other.littleRoleId_;
			this.equipItems_ = other.equipItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00033577 File Offset: 0x00031777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutRequest Clone()
		{
			return new AbyssPluginPutRequest(this);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x0003357F File Offset: 0x0003177F
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00033587 File Offset: 0x00031787
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
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00033590 File Offset: 0x00031790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipItems
		{
			get
			{
				return this.equipItems_;
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00033598 File Offset: 0x00031798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginPutRequest);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000335A8 File Offset: 0x000317A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginPutRequest other)
		{
			return other != null && (other == this || (this.LittleRoleId == other.LittleRoleId && this.equipItems_.Equals(other.equipItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000335F8 File Offset: 0x000317F8
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

		// Token: 0x060012C5 RID: 4805 RVA: 0x00033645 File Offset: 0x00031845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00033652 File Offset: 0x00031852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003365C File Offset: 0x0003185C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipItems_.WriteTo(ref output, AbyssPluginPutRequest._repeated_equipItems_codec);
			if (this.LittleRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LittleRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000336AC File Offset: 0x000318AC
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

		// Token: 0x060012C9 RID: 4809 RVA: 0x00033700 File Offset: 0x00031900
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

		// Token: 0x060012CA RID: 4810 RVA: 0x0003374D File Offset: 0x0003194D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00033758 File Offset: 0x00031958
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
				if (num != 24U && num != 26U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LittleRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.equipItems_.AddEntriesFrom(ref input, AbyssPluginPutRequest._repeated_equipItems_codec);
				}
			}
		}

		// Token: 0x04001FE0 RID: 8160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FE1 RID: 8161
		public const int LittleRoleIdFieldNumber = 6;

		// Token: 0x04001FE2 RID: 8162
		private int littleRoleId_;

		// Token: 0x04001FE3 RID: 8163
		public const int EquipItemsFieldNumber = 3;

		// Token: 0x04001FE4 RID: 8164
		private static readonly FieldCodec<int> _repeated_equipItems_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04001FE5 RID: 8165
		private readonly RepeatedField<int> equipItems_ = new RepeatedField<int>();
	}
}
