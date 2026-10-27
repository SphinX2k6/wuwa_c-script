using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8B RID: 2699
	[NetMessage(EMessageId.MotorOutlookOwnedChangeNotify)]
	public sealed class MotorOutlookOwnedChangeNotify : IMessage<MotorOutlookOwnedChangeNotify>, IMessage, IEquatable<MotorOutlookOwnedChangeNotify>, IDeepCloneable<MotorOutlookOwnedChangeNotify>, IBufferMessage
	{
		// Token: 0x0600EB17 RID: 60183 RVA: 0x00224FF7 File Offset: 0x002231F7
		[NullableContext(1)]
		public static MotorOutlookOwnedChangeNotify Create()
		{
			return new MotorOutlookOwnedChangeNotify();
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600EB18 RID: 60184 RVA: 0x00224FFE File Offset: 0x002231FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600EB19 RID: 60185 RVA: 0x00225001 File Offset: 0x00223201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookOwnedChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x00225008 File Offset: 0x00223208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify()
		{
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x00225010 File Offset: 0x00223210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify(MotorOutlookOwnedChangeNotify other) : this()
		{
			this.motorOutlookOwned_ = ((other.motorOutlookOwned_ != null) ? other.motorOutlookOwned_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x00225045 File Offset: 0x00223245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify Clone()
		{
			return new MotorOutlookOwnedChangeNotify(this);
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x0022504D File Offset: 0x0022324D
		// (set) Token: 0x0600EB1E RID: 60190 RVA: 0x00225055 File Offset: 0x00223255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb MotorOutlookOwned
		{
			get
			{
				return this.motorOutlookOwned_;
			}
			set
			{
				this.motorOutlookOwned_ = value;
			}
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x0022505E File Offset: 0x0022325E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookOwnedChangeNotify);
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x0022506C File Offset: 0x0022326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookOwnedChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookOwned, other.MotorOutlookOwned) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x002250A0 File Offset: 0x002232A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookOwned_ != null)
			{
				num ^= this.MotorOutlookOwned.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x002250DC File Offset: 0x002232DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB23 RID: 60195 RVA: 0x002250E9 File Offset: 0x002232E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB24 RID: 60196 RVA: 0x002250F2 File Offset: 0x002232F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookOwned_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MotorOutlookOwned);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x00225124 File Offset: 0x00223324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookOwned_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookOwned);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x00225164 File Offset: 0x00223364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookOwnedChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookOwned_ != null)
			{
				if (this.motorOutlookOwned_ == null)
				{
					this.MotorOutlookOwned = new MotorOutlookOwnedPb();
				}
				this.MotorOutlookOwned.MergeFrom(other.MotorOutlookOwned);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x002251B8 File Offset: 0x002233B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x002251C4 File Offset: 0x002233C4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.motorOutlookOwned_ == null)
					{
						this.MotorOutlookOwned = new MotorOutlookOwnedPb();
					}
					input.ReadMessage(this.MotorOutlookOwned);
				}
			}
		}

		// Token: 0x04005F62 RID: 24418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F63 RID: 24419
		public const int MotorOutlookOwnedFieldNumber = 10;

		// Token: 0x04005F64 RID: 24420
		private MotorOutlookOwnedPb motorOutlookOwned_;
	}
}
