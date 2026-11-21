using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C6 RID: 4294
	[NetMessage(EMessageId.RoleTowerDieNotify)]
	public sealed class RoleTowerDieNotify : IMessage<RoleTowerDieNotify>, IMessage, IEquatable<RoleTowerDieNotify>, IDeepCloneable<RoleTowerDieNotify>, IBufferMessage
	{
		// Token: 0x06016F31 RID: 94001 RVA: 0x003564C4 File Offset: 0x003546C4
		[NullableContext(1)]
		public static RoleTowerDieNotify Create()
		{
			return new RoleTowerDieNotify();
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06016F32 RID: 94002 RVA: 0x003564CB File Offset: 0x003546CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x06016F33 RID: 94003 RVA: 0x003564CE File Offset: 0x003546CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerDieNotify.Descriptor;
			}
		}

		// Token: 0x06016F34 RID: 94004 RVA: 0x003564D5 File Offset: 0x003546D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerDieNotify()
		{
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x003564DD File Offset: 0x003546DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerDieNotify(RoleTowerDieNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x003564F6 File Offset: 0x003546F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerDieNotify Clone()
		{
			return new RoleTowerDieNotify(this);
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x003564FE File Offset: 0x003546FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerDieNotify);
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x0035650C File Offset: 0x0035470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerDieNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x0035652C File Offset: 0x0035472C
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

		// Token: 0x06016F3A RID: 94010 RVA: 0x00356552 File Offset: 0x00354752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F3B RID: 94011 RVA: 0x0035655F File Offset: 0x0035475F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F3C RID: 94012 RVA: 0x00356568 File Offset: 0x00354768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F3D RID: 94013 RVA: 0x00356580 File Offset: 0x00354780
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

		// Token: 0x06016F3E RID: 94014 RVA: 0x003565A6 File Offset: 0x003547A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerDieNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F3F RID: 94015 RVA: 0x003565C3 File Offset: 0x003547C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F40 RID: 94016 RVA: 0x003565CC File Offset: 0x003547CC
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

		// Token: 0x04008956 RID: 35158
		private UnknownFieldSet _unknownFields;
	}
}
