using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000039 RID: 57
	[NetMessage(EMessageId.AbyssRankListRequest)]
	public sealed class AbyssRankListRequest : IMessage<AbyssRankListRequest>, IMessage, IEquatable<AbyssRankListRequest>, IDeepCloneable<AbyssRankListRequest>, IBufferMessage
	{
		// Token: 0x06001305 RID: 4869 RVA: 0x00033E3C File Offset: 0x0003203C
		[NullableContext(1)]
		public static AbyssRankListRequest Create()
		{
			return new AbyssRankListRequest();
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00033E43 File Offset: 0x00032043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00033E46 File Offset: 0x00032046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRankListRequest.Descriptor;
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00033E4D File Offset: 0x0003204D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest()
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00033E55 File Offset: 0x00032055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest(AbyssRankListRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00033E7A File Offset: 0x0003207A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListRequest Clone()
		{
			return new AbyssRankListRequest(this);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00033E82 File Offset: 0x00032082
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x00033E8A File Offset: 0x0003208A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00033E93 File Offset: 0x00032093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRankListRequest);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00033EA1 File Offset: 0x000320A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRankListRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00033ED0 File Offset: 0x000320D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00033F0F File Offset: 0x0003210F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00033F1C File Offset: 0x0003211C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00033F25 File Offset: 0x00032125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00033F58 File Offset: 0x00032158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00033F96 File Offset: 0x00032196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRankListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00033FC7 File Offset: 0x000321C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00033FD0 File Offset: 0x000321D0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FF3 RID: 8179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF4 RID: 8180
		public const int IdFieldNumber = 1;

		// Token: 0x04001FF5 RID: 8181
		private int id_;
	}
}
