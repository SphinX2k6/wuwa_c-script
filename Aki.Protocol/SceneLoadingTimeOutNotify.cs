using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117F RID: 4479
	[NetMessage(EMessageId.SceneLoadingTimeOutNotify)]
	public sealed class SceneLoadingTimeOutNotify : IMessage<SceneLoadingTimeOutNotify>, IMessage, IEquatable<SceneLoadingTimeOutNotify>, IDeepCloneable<SceneLoadingTimeOutNotify>, IBufferMessage
	{
		// Token: 0x06017DEF RID: 97775 RVA: 0x003775C5 File Offset: 0x003757C5
		[NullableContext(1)]
		public static SceneLoadingTimeOutNotify Create()
		{
			return new SceneLoadingTimeOutNotify();
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x06017DF0 RID: 97776 RVA: 0x003775CC File Offset: 0x003757CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x06017DF1 RID: 97777 RVA: 0x003775CF File Offset: 0x003757CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingTimeOutNotify.Descriptor;
			}
		}

		// Token: 0x06017DF2 RID: 97778 RVA: 0x003775D6 File Offset: 0x003757D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify()
		{
		}

		// Token: 0x06017DF3 RID: 97779 RVA: 0x003775DE File Offset: 0x003757DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify(SceneLoadingTimeOutNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DF4 RID: 97780 RVA: 0x003775F7 File Offset: 0x003757F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify Clone()
		{
			return new SceneLoadingTimeOutNotify(this);
		}

		// Token: 0x06017DF5 RID: 97781 RVA: 0x003775FF File Offset: 0x003757FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingTimeOutNotify);
		}

		// Token: 0x06017DF6 RID: 97782 RVA: 0x0037760D File Offset: 0x0037580D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingTimeOutNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06017DF7 RID: 97783 RVA: 0x0037762C File Offset: 0x0037582C
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

		// Token: 0x06017DF8 RID: 97784 RVA: 0x00377652 File Offset: 0x00375852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DF9 RID: 97785 RVA: 0x0037765F File Offset: 0x0037585F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DFA RID: 97786 RVA: 0x00377668 File Offset: 0x00375868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x00377680 File Offset: 0x00375880
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

		// Token: 0x06017DFC RID: 97788 RVA: 0x003776A6 File Offset: 0x003758A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingTimeOutNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x003776C3 File Offset: 0x003758C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x003776CC File Offset: 0x003758CC
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

		// Token: 0x04008D70 RID: 36208
		private UnknownFieldSet _unknownFields;
	}
}
