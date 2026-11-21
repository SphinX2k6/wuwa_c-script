using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001064 RID: 4196
	[NetMessage(EMessageId.RoleFavorListRequest)]
	public sealed class RoleFavorListRequest : IMessage<RoleFavorListRequest>, IMessage, IEquatable<RoleFavorListRequest>, IDeepCloneable<RoleFavorListRequest>, IBufferMessage
	{
		// Token: 0x06016737 RID: 91959 RVA: 0x003443B8 File Offset: 0x003425B8
		[NullableContext(1)]
		public static RoleFavorListRequest Create()
		{
			return new RoleFavorListRequest();
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x06016738 RID: 91960 RVA: 0x003443BF File Offset: 0x003425BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x06016739 RID: 91961 RVA: 0x003443C2 File Offset: 0x003425C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListRequest.Descriptor;
			}
		}

		// Token: 0x0601673A RID: 91962 RVA: 0x003443C9 File Offset: 0x003425C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest()
		{
		}

		// Token: 0x0601673B RID: 91963 RVA: 0x003443D1 File Offset: 0x003425D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest(RoleFavorListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601673C RID: 91964 RVA: 0x003443EA File Offset: 0x003425EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest Clone()
		{
			return new RoleFavorListRequest(this);
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x003443F2 File Offset: 0x003425F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListRequest);
		}

		// Token: 0x0601673E RID: 91966 RVA: 0x00344400 File Offset: 0x00342600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601673F RID: 91967 RVA: 0x00344420 File Offset: 0x00342620
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

		// Token: 0x06016740 RID: 91968 RVA: 0x00344446 File Offset: 0x00342646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016741 RID: 91969 RVA: 0x00344453 File Offset: 0x00342653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016742 RID: 91970 RVA: 0x0034445C File Offset: 0x0034265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016743 RID: 91971 RVA: 0x00344474 File Offset: 0x00342674
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

		// Token: 0x06016744 RID: 91972 RVA: 0x0034449A File Offset: 0x0034269A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016745 RID: 91973 RVA: 0x003444B7 File Offset: 0x003426B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016746 RID: 91974 RVA: 0x003444C0 File Offset: 0x003426C0
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

		// Token: 0x040086C5 RID: 34501
		private UnknownFieldSet _unknownFields;
	}
}
