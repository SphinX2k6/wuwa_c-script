using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000068 RID: 104
	[NetMessage(EMessageId.AchievementUpdateRequest)]
	public sealed class AchievementUpdateRequest : IMessage<AchievementUpdateRequest>, IMessage, IEquatable<AchievementUpdateRequest>, IDeepCloneable<AchievementUpdateRequest>, IBufferMessage
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x0003BF45 File Offset: 0x0003A145
		[NullableContext(1)]
		public static AchievementUpdateRequest Create()
		{
			return new AchievementUpdateRequest();
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0003BF4C File Offset: 0x0003A14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0003BF4F File Offset: 0x0003A14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementUpdateRequest.Descriptor;
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0003BF56 File Offset: 0x0003A156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest()
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0003BF5E File Offset: 0x0003A15E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest(AchievementUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0003BF77 File Offset: 0x0003A177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest Clone()
		{
			return new AchievementUpdateRequest(this);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0003BF7F File Offset: 0x0003A17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementUpdateRequest);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0003BF8D File Offset: 0x0003A18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0003BFAC File Offset: 0x0003A1AC
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

		// Token: 0x060016EA RID: 5866 RVA: 0x0003BFD2 File Offset: 0x0003A1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0003BFDF File Offset: 0x0003A1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0003C000 File Offset: 0x0003A200
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

		// Token: 0x060016EE RID: 5870 RVA: 0x0003C026 File Offset: 0x0003A226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0003C043 File Offset: 0x0003A243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0003C04C File Offset: 0x0003A24C
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

		// Token: 0x0400214E RID: 8526
		private UnknownFieldSet _unknownFields;
	}
}
