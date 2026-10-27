using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001282 RID: 4738
	[NetMessage(EMessageId.SpringSignPhotoRewardRequest)]
	public sealed class SpringSignPhotoRewardRequest : IMessage<SpringSignPhotoRewardRequest>, IMessage, IEquatable<SpringSignPhotoRewardRequest>, IDeepCloneable<SpringSignPhotoRewardRequest>, IBufferMessage
	{
		// Token: 0x060193C1 RID: 103361 RVA: 0x003ABCA2 File Offset: 0x003A9EA2
		[NullableContext(1)]
		public static SpringSignPhotoRewardRequest Create()
		{
			return new SpringSignPhotoRewardRequest();
		}

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x060193C2 RID: 103362 RVA: 0x003ABCA9 File Offset: 0x003A9EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x060193C3 RID: 103363 RVA: 0x003ABCAC File Offset: 0x003A9EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignPhotoRewardRequest.Descriptor;
			}
		}

		// Token: 0x060193C4 RID: 103364 RVA: 0x003ABCB3 File Offset: 0x003A9EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest()
		{
		}

		// Token: 0x060193C5 RID: 103365 RVA: 0x003ABCBB File Offset: 0x003A9EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest(SpringSignPhotoRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193C6 RID: 103366 RVA: 0x003ABCD4 File Offset: 0x003A9ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest Clone()
		{
			return new SpringSignPhotoRewardRequest(this);
		}

		// Token: 0x060193C7 RID: 103367 RVA: 0x003ABCDC File Offset: 0x003A9EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignPhotoRewardRequest);
		}

		// Token: 0x060193C8 RID: 103368 RVA: 0x003ABCEA File Offset: 0x003A9EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignPhotoRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060193C9 RID: 103369 RVA: 0x003ABD08 File Offset: 0x003A9F08
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

		// Token: 0x060193CA RID: 103370 RVA: 0x003ABD2E File Offset: 0x003A9F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193CB RID: 103371 RVA: 0x003ABD3B File Offset: 0x003A9F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193CC RID: 103372 RVA: 0x003ABD44 File Offset: 0x003A9F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060193CD RID: 103373 RVA: 0x003ABD5C File Offset: 0x003A9F5C
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

		// Token: 0x060193CE RID: 103374 RVA: 0x003ABD82 File Offset: 0x003A9F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignPhotoRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060193CF RID: 103375 RVA: 0x003ABD9F File Offset: 0x003A9F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193D0 RID: 103376 RVA: 0x003ABDA8 File Offset: 0x003A9FA8
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

		// Token: 0x04009479 RID: 38009
		private UnknownFieldSet _unknownFields;
	}
}
