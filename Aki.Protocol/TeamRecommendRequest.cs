using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A0 RID: 5024
	[NetMessage(EMessageId.TeamRecommendRequest)]
	public sealed class TeamRecommendRequest : IMessage<TeamRecommendRequest>, IMessage, IEquatable<TeamRecommendRequest>, IDeepCloneable<TeamRecommendRequest>, IBufferMessage
	{
		// Token: 0x0601ABDE RID: 109534 RVA: 0x003E51A9 File Offset: 0x003E33A9
		[NullableContext(1)]
		public static TeamRecommendRequest Create()
		{
			return new TeamRecommendRequest();
		}

		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x0601ABDF RID: 109535 RVA: 0x003E51B0 File Offset: 0x003E33B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x0601ABE0 RID: 109536 RVA: 0x003E51B3 File Offset: 0x003E33B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0601ABE1 RID: 109537 RVA: 0x003E51BA File Offset: 0x003E33BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRequest()
		{
		}

		// Token: 0x0601ABE2 RID: 109538 RVA: 0x003E51C2 File Offset: 0x003E33C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRequest(TeamRecommendRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABE3 RID: 109539 RVA: 0x003E51DB File Offset: 0x003E33DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRequest Clone()
		{
			return new TeamRecommendRequest(this);
		}

		// Token: 0x0601ABE4 RID: 109540 RVA: 0x003E51E3 File Offset: 0x003E33E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendRequest);
		}

		// Token: 0x0601ABE5 RID: 109541 RVA: 0x003E51F1 File Offset: 0x003E33F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601ABE6 RID: 109542 RVA: 0x003E5210 File Offset: 0x003E3410
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

		// Token: 0x0601ABE7 RID: 109543 RVA: 0x003E5236 File Offset: 0x003E3436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABE8 RID: 109544 RVA: 0x003E5243 File Offset: 0x003E3443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABE9 RID: 109545 RVA: 0x003E524C File Offset: 0x003E344C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABEA RID: 109546 RVA: 0x003E5264 File Offset: 0x003E3464
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

		// Token: 0x0601ABEB RID: 109547 RVA: 0x003E528A File Offset: 0x003E348A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABEC RID: 109548 RVA: 0x003E52A7 File Offset: 0x003E34A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABED RID: 109549 RVA: 0x003E52B0 File Offset: 0x003E34B0
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

		// Token: 0x04009C8C RID: 40076
		private UnknownFieldSet _unknownFields;
	}
}
