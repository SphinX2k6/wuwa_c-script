using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1A RID: 3098
	[NetMessage(EMessageId.PhantomAutoPutRequest)]
	public sealed class PhantomAutoPutRequest : IMessage<PhantomAutoPutRequest>, IMessage, IEquatable<PhantomAutoPutRequest>, IDeepCloneable<PhantomAutoPutRequest>, IBufferMessage
	{
		// Token: 0x06010D0F RID: 68879 RVA: 0x00276710 File Offset: 0x00274910
		[NullableContext(1)]
		public static PhantomAutoPutRequest Create()
		{
			return new PhantomAutoPutRequest();
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x06010D10 RID: 68880 RVA: 0x00276717 File Offset: 0x00274917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x06010D11 RID: 68881 RVA: 0x0027671A File Offset: 0x0027491A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAutoPutRequest.Descriptor;
			}
		}

		// Token: 0x06010D12 RID: 68882 RVA: 0x00276721 File Offset: 0x00274921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest()
		{
		}

		// Token: 0x06010D13 RID: 68883 RVA: 0x00276734 File Offset: 0x00274934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest(PhantomAutoPutRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantomItemIncrId_ = other.phantomItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D14 RID: 68884 RVA: 0x0027676A File Offset: 0x0027496A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest Clone()
		{
			return new PhantomAutoPutRequest(this);
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x06010D15 RID: 68885 RVA: 0x00276772 File Offset: 0x00274972
		// (set) Token: 0x06010D16 RID: 68886 RVA: 0x0027677A File Offset: 0x0027497A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x06010D17 RID: 68887 RVA: 0x00276783 File Offset: 0x00274983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrId
		{
			get
			{
				return this.phantomItemIncrId_;
			}
		}

		// Token: 0x06010D18 RID: 68888 RVA: 0x0027678B File Offset: 0x0027498B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAutoPutRequest);
		}

		// Token: 0x06010D19 RID: 68889 RVA: 0x0027679C File Offset: 0x0027499C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAutoPutRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.phantomItemIncrId_.Equals(other.phantomItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D1A RID: 68890 RVA: 0x002767EC File Offset: 0x002749EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.phantomItemIncrId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010D1B RID: 68891 RVA: 0x00276839 File Offset: 0x00274A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D1C RID: 68892 RVA: 0x00276846 File Offset: 0x00274A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D1D RID: 68893 RVA: 0x00276850 File Offset: 0x00274A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			this.phantomItemIncrId_.WriteTo(ref output, PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D1E RID: 68894 RVA: 0x002768A0 File Offset: 0x00274AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.phantomItemIncrId_.CalculateSize(PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010D1F RID: 68895 RVA: 0x002768F4 File Offset: 0x00274AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAutoPutRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.phantomItemIncrId_.Add(other.phantomItemIncrId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010D20 RID: 68896 RVA: 0x00276941 File Offset: 0x00274B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D21 RID: 68897 RVA: 0x0027694C File Offset: 0x00274B4C
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
				if (num != 64U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomItemIncrId_.AddEntriesFrom(ref input, PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006AC3 RID: 27331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AC4 RID: 27332
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04006AC5 RID: 27333
		private int roleId_;

		// Token: 0x04006AC6 RID: 27334
		public const int PhantomItemIncrIdFieldNumber = 9;

		// Token: 0x04006AC7 RID: 27335
		private static readonly FieldCodec<int> _repeated_phantomItemIncrId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006AC8 RID: 27336
		private readonly RepeatedField<int> phantomItemIncrId_ = new RepeatedField<int>();
	}
}
