using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FD RID: 765
	[NetMessage(EMessageId.CookingDataRequest)]
	public sealed class CookingDataRequest : IMessage<CookingDataRequest>, IMessage, IEquatable<CookingDataRequest>, IDeepCloneable<CookingDataRequest>, IBufferMessage
	{
		// Token: 0x06004DA3 RID: 19875 RVA: 0x000BD088 File Offset: 0x000BB288
		[NullableContext(1)]
		public static CookingDataRequest Create()
		{
			return new CookingDataRequest();
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x000BD08F File Offset: 0x000BB28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x000BD092 File Offset: 0x000BB292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingDataRequest.Descriptor;
			}
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x000BD099 File Offset: 0x000BB299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest()
		{
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x000BD0A1 File Offset: 0x000BB2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest(CookingDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x000BD0BA File Offset: 0x000BB2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest Clone()
		{
			return new CookingDataRequest(this);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x000BD0C2 File Offset: 0x000BB2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingDataRequest);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x000BD0D0 File Offset: 0x000BB2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
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

		// Token: 0x06004DAC RID: 19884 RVA: 0x000BD116 File Offset: 0x000BB316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x000BD123 File Offset: 0x000BB323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x000BD12C File Offset: 0x000BB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x000BD144 File Offset: 0x000BB344
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

		// Token: 0x06004DB0 RID: 19888 RVA: 0x000BD16A File Offset: 0x000BB36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000BD187 File Offset: 0x000BB387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x000BD190 File Offset: 0x000BB390
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

		// Token: 0x040031B0 RID: 12720
		private UnknownFieldSet _unknownFields;
	}
}
