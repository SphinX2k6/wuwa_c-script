using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE6 RID: 3302
	[NetMessage(EMessageId.PhantomRecommendRequest)]
	public sealed class PhantomRecommendRequest : IMessage<PhantomRecommendRequest>, IMessage, IEquatable<PhantomRecommendRequest>, IDeepCloneable<PhantomRecommendRequest>, IBufferMessage
	{
		// Token: 0x06011E16 RID: 73238 RVA: 0x0029DF98 File Offset: 0x0029C198
		[NullableContext(1)]
		public static PhantomRecommendRequest Create()
		{
			return new PhantomRecommendRequest();
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x06011E17 RID: 73239 RVA: 0x0029DF9F File Offset: 0x0029C19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x06011E18 RID: 73240 RVA: 0x0029DFA2 File Offset: 0x0029C1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06011E19 RID: 73241 RVA: 0x0029DFA9 File Offset: 0x0029C1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest()
		{
		}

		// Token: 0x06011E1A RID: 73242 RVA: 0x0029DFB1 File Offset: 0x0029C1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest(PhantomRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E1B RID: 73243 RVA: 0x0029DFD6 File Offset: 0x0029C1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest Clone()
		{
			return new PhantomRecommendRequest(this);
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x06011E1C RID: 73244 RVA: 0x0029DFDE File Offset: 0x0029C1DE
		// (set) Token: 0x06011E1D RID: 73245 RVA: 0x0029DFE6 File Offset: 0x0029C1E6
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

		// Token: 0x06011E1E RID: 73246 RVA: 0x0029DFEF File Offset: 0x0029C1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendRequest);
		}

		// Token: 0x06011E1F RID: 73247 RVA: 0x0029DFFD File Offset: 0x0029C1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E20 RID: 73248 RVA: 0x0029E02C File Offset: 0x0029C22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011E21 RID: 73249 RVA: 0x0029E06B File Offset: 0x0029C26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E22 RID: 73250 RVA: 0x0029E078 File Offset: 0x0029C278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E23 RID: 73251 RVA: 0x0029E081 File Offset: 0x0029C281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E24 RID: 73252 RVA: 0x0029E0B4 File Offset: 0x0029C2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E25 RID: 73253 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E26 RID: 73254 RVA: 0x0029E123 File Offset: 0x0029C323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E27 RID: 73255 RVA: 0x0029E12C File Offset: 0x0029C32C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007097 RID: 28823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007098 RID: 28824
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04007099 RID: 28825
		private int roleId_;
	}
}
