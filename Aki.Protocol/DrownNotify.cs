using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FE RID: 1022
	[NetMessage(EMessageId.DrownNotify)]
	public sealed class DrownNotify : IMessage<DrownNotify>, IMessage, IEquatable<DrownNotify>, IDeepCloneable<DrownNotify>, IBufferMessage
	{
		// Token: 0x060062FA RID: 25338 RVA: 0x000EE419 File Offset: 0x000EC619
		[NullableContext(1)]
		public static DrownNotify Create()
		{
			return new DrownNotify();
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x000EE420 File Offset: 0x000EC620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x000EE423 File Offset: 0x000EC623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownNotify.Descriptor;
			}
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x000EE42A File Offset: 0x000EC62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify()
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x000EE432 File Offset: 0x000EC632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify(DrownNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x000EE44B File Offset: 0x000EC64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify Clone()
		{
			return new DrownNotify(this);
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x000EE453 File Offset: 0x000EC653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownNotify);
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x000EE461 File Offset: 0x000EC661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x000EE480 File Offset: 0x000EC680
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

		// Token: 0x06006303 RID: 25347 RVA: 0x000EE4A6 File Offset: 0x000EC6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x000EE4B3 File Offset: 0x000EC6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x000EE4BC File Offset: 0x000EC6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x000EE4D4 File Offset: 0x000EC6D4
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

		// Token: 0x06006307 RID: 25351 RVA: 0x000EE4FA File Offset: 0x000EC6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x000EE517 File Offset: 0x000EC717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x000EE520 File Offset: 0x000EC720
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

		// Token: 0x04003857 RID: 14423
		private UnknownFieldSet _unknownFields;
	}
}
