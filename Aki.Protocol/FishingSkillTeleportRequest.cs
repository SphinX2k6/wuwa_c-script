using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000588 RID: 1416
	[NetMessage(EMessageId.FishingSkillTeleportRequest)]
	public sealed class FishingSkillTeleportRequest : IMessage<FishingSkillTeleportRequest>, IMessage, IEquatable<FishingSkillTeleportRequest>, IDeepCloneable<FishingSkillTeleportRequest>, IBufferMessage
	{
		// Token: 0x06008364 RID: 33636 RVA: 0x0013C958 File Offset: 0x0013AB58
		[NullableContext(1)]
		public static FishingSkillTeleportRequest Create()
		{
			return new FishingSkillTeleportRequest();
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x0013C95F File Offset: 0x0013AB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06008366 RID: 33638 RVA: 0x0013C962 File Offset: 0x0013AB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x0013C969 File Offset: 0x0013AB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest()
		{
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x0013C971 File Offset: 0x0013AB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest(FishingSkillTeleportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x0013C98A File Offset: 0x0013AB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest Clone()
		{
			return new FishingSkillTeleportRequest(this);
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x0013C992 File Offset: 0x0013AB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillTeleportRequest);
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x0013C9A0 File Offset: 0x0013ABA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillTeleportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0013C9C0 File Offset: 0x0013ABC0
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

		// Token: 0x0600836D RID: 33645 RVA: 0x0013C9E6 File Offset: 0x0013ABE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0013C9F3 File Offset: 0x0013ABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0013C9FC File Offset: 0x0013ABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0013CA14 File Offset: 0x0013AC14
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

		// Token: 0x06008371 RID: 33649 RVA: 0x0013CA3A File Offset: 0x0013AC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x0013CA57 File Offset: 0x0013AC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x0013CA60 File Offset: 0x0013AC60
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

		// Token: 0x04004178 RID: 16760
		private UnknownFieldSet _unknownFields;
	}
}
