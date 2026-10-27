using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151A RID: 5402
	[NetMessage(EMessageId.WorldLevelDownRequest)]
	public sealed class WorldLevelDownRequest : IMessage<WorldLevelDownRequest>, IMessage, IEquatable<WorldLevelDownRequest>, IDeepCloneable<WorldLevelDownRequest>, IBufferMessage
	{
		// Token: 0x0601C8B3 RID: 116915 RVA: 0x0041F084 File Offset: 0x0041D284
		[NullableContext(1)]
		public static WorldLevelDownRequest Create()
		{
			return new WorldLevelDownRequest();
		}

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x0601C8B4 RID: 116916 RVA: 0x0041F08B File Offset: 0x0041D28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x0601C8B5 RID: 116917 RVA: 0x0041F08E File Offset: 0x0041D28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelDownRequest.Descriptor;
			}
		}

		// Token: 0x0601C8B6 RID: 116918 RVA: 0x0041F095 File Offset: 0x0041D295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest()
		{
		}

		// Token: 0x0601C8B7 RID: 116919 RVA: 0x0041F09D File Offset: 0x0041D29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest(WorldLevelDownRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8B8 RID: 116920 RVA: 0x0041F0B6 File Offset: 0x0041D2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest Clone()
		{
			return new WorldLevelDownRequest(this);
		}

		// Token: 0x0601C8B9 RID: 116921 RVA: 0x0041F0BE File Offset: 0x0041D2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelDownRequest);
		}

		// Token: 0x0601C8BA RID: 116922 RVA: 0x0041F0CC File Offset: 0x0041D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelDownRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C8BB RID: 116923 RVA: 0x0041F0EC File Offset: 0x0041D2EC
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

		// Token: 0x0601C8BC RID: 116924 RVA: 0x0041F112 File Offset: 0x0041D312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8BD RID: 116925 RVA: 0x0041F11F File Offset: 0x0041D31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8BE RID: 116926 RVA: 0x0041F128 File Offset: 0x0041D328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8BF RID: 116927 RVA: 0x0041F140 File Offset: 0x0041D340
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

		// Token: 0x0601C8C0 RID: 116928 RVA: 0x0041F166 File Offset: 0x0041D366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelDownRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8C1 RID: 116929 RVA: 0x0041F183 File Offset: 0x0041D383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8C2 RID: 116930 RVA: 0x0041F18C File Offset: 0x0041D38C
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

		// Token: 0x0400A33D RID: 41789
		private UnknownFieldSet _unknownFields;
	}
}
