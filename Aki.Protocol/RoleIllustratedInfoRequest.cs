using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001076 RID: 4214
	[NetMessage(EMessageId.RoleIllustratedInfoRequest)]
	public sealed class RoleIllustratedInfoRequest : IMessage<RoleIllustratedInfoRequest>, IMessage, IEquatable<RoleIllustratedInfoRequest>, IDeepCloneable<RoleIllustratedInfoRequest>, IBufferMessage
	{
		// Token: 0x06016899 RID: 92313 RVA: 0x00346EDB File Offset: 0x003450DB
		[NullableContext(1)]
		public static RoleIllustratedInfoRequest Create()
		{
			return new RoleIllustratedInfoRequest();
		}

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x0601689A RID: 92314 RVA: 0x00346EE2 File Offset: 0x003450E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x0601689B RID: 92315 RVA: 0x00346EE5 File Offset: 0x003450E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601689C RID: 92316 RVA: 0x00346EEC File Offset: 0x003450EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest()
		{
		}

		// Token: 0x0601689D RID: 92317 RVA: 0x00346EF4 File Offset: 0x003450F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest(RoleIllustratedInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601689E RID: 92318 RVA: 0x00346F0D File Offset: 0x0034510D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest Clone()
		{
			return new RoleIllustratedInfoRequest(this);
		}

		// Token: 0x0601689F RID: 92319 RVA: 0x00346F15 File Offset: 0x00345115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfoRequest);
		}

		// Token: 0x060168A0 RID: 92320 RVA: 0x00346F23 File Offset: 0x00345123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060168A1 RID: 92321 RVA: 0x00346F44 File Offset: 0x00345144
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

		// Token: 0x060168A2 RID: 92322 RVA: 0x00346F6A File Offset: 0x0034516A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168A3 RID: 92323 RVA: 0x00346F77 File Offset: 0x00345177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168A4 RID: 92324 RVA: 0x00346F80 File Offset: 0x00345180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168A5 RID: 92325 RVA: 0x00346F98 File Offset: 0x00345198
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

		// Token: 0x060168A6 RID: 92326 RVA: 0x00346FBE File Offset: 0x003451BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleIllustratedInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060168A7 RID: 92327 RVA: 0x00346FDB File Offset: 0x003451DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168A8 RID: 92328 RVA: 0x00346FE4 File Offset: 0x003451E4
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

		// Token: 0x04008719 RID: 34585
		private UnknownFieldSet _unknownFields;
	}
}
