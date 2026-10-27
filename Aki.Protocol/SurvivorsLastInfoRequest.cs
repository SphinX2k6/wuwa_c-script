using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CC RID: 4812
	[NetMessage(EMessageId.SurvivorsLastInfoRequest)]
	public sealed class SurvivorsLastInfoRequest : IMessage<SurvivorsLastInfoRequest>, IMessage, IEquatable<SurvivorsLastInfoRequest>, IDeepCloneable<SurvivorsLastInfoRequest>, IBufferMessage
	{
		// Token: 0x060199AF RID: 104879 RVA: 0x003B91A3 File Offset: 0x003B73A3
		[NullableContext(1)]
		public static SurvivorsLastInfoRequest Create()
		{
			return new SurvivorsLastInfoRequest();
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x060199B0 RID: 104880 RVA: 0x003B91AA File Offset: 0x003B73AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x060199B1 RID: 104881 RVA: 0x003B91AD File Offset: 0x003B73AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x060199B2 RID: 104882 RVA: 0x003B91B4 File Offset: 0x003B73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest()
		{
		}

		// Token: 0x060199B3 RID: 104883 RVA: 0x003B91BC File Offset: 0x003B73BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest(SurvivorsLastInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199B4 RID: 104884 RVA: 0x003B91D5 File Offset: 0x003B73D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest Clone()
		{
			return new SurvivorsLastInfoRequest(this);
		}

		// Token: 0x060199B5 RID: 104885 RVA: 0x003B91DD File Offset: 0x003B73DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLastInfoRequest);
		}

		// Token: 0x060199B6 RID: 104886 RVA: 0x003B91EB File Offset: 0x003B73EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLastInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060199B7 RID: 104887 RVA: 0x003B920C File Offset: 0x003B740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060199B8 RID: 104888 RVA: 0x003B9232 File Offset: 0x003B7432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199B9 RID: 104889 RVA: 0x003B923F File Offset: 0x003B743F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199BA RID: 104890 RVA: 0x003B9248 File Offset: 0x003B7448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199BB RID: 104891 RVA: 0x003B9260 File Offset: 0x003B7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060199BC RID: 104892 RVA: 0x003B9286 File Offset: 0x003B7486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060199BD RID: 104893 RVA: 0x003B92A3 File Offset: 0x003B74A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199BE RID: 104894 RVA: 0x003B92AC File Offset: 0x003B74AC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400963A RID: 38458
		private UnknownFieldSet _unknownFields;
	}
}
